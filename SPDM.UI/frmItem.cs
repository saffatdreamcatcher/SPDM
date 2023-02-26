using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmItem : Form
    {
        private int id = 0;
        private int itemId;

        public frmItem()
        {
            InitializeComponent();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        //private void LoadCategory()
        //{

        //    CategoryBLL categoryBLL = new CategoryBLL();        
        //    List<Category> categories = categoryBLL.GetAll();   
        //    cboCategory.DataSource = categories;               
        //    cboCategory.ValueMember = "Id";                 
        //    cboCategory.DisplayMember = "Description";       

        //}
        private void LoadCategory()
        {
            Category category1 = new Category();
            category1.Id = -1;
            category1.Name = "Please Select-";

            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> categories = categoryBLL.GetAll();
            categories.Insert(0, category1);
            cboCategory.DataSource = categories;
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            List<Category> categoriesSearch = categoryBLL.GetAll();
            categoriesSearch.Insert(0, category1);
            cboCategory.DataSource = categoriesSearch;
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
        }

        private void LoadItem()
        {
            ItemBLL itemBLL = new ItemBLL();
            List<Item> item = itemBLL.GetAll();     
                                                                   
            gvItem.DataSource = item;                    
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            
            LoadCategory();
            LoadItem();
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                itemId = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[0].Value);  
                txtDescription.Text = Convert.ToString(gvItem.Rows[e.RowIndex].Cells[6].Value);
                cboCategory.SelectedValue = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[4].Value);
                txtName.Text = Convert.ToString(gvItem.Rows[e.RowIndex].Cells[1].Value);
                txtNumber.Text = Convert.ToString(gvItem.Rows[e.RowIndex].Cells[5].Value);
                nUpUnit.Value = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[7].Value);
                nUpPrice.Value = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[8].Value);
                nUpVatRate.Value = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[9].Value);
                chkIsBlocked.Checked = Convert.ToBoolean(gvItem.Rows[e.RowIndex].Cells[11].Value);

                ItemBLL itemBLL = new ItemBLL();
                Item item = itemBLL.GetById(itemId);
                if (item.Photo != null)
                {
                    MemoryStream ms = new MemoryStream(item.Photo);
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                }
            }
            else if (e.ColumnIndex == 15)
            {
                var id = Convert.ToInt32(gvItem.Rows[e.RowIndex].Cells[0].Value);
                DeleteItem(id);
            }
        }

        private void DeleteItem(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete the item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ItemBLL itemBLL = new ItemBLL();
                itemBLL.Delete(id);
                LoadItem();
            }

        }

        private void gvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void ClearField()
        {
            txtName.Text = string.Empty;
            itemId = 0;
            cboCategory.SelectedValue = string.Empty;
            txtNumber.Text = string.Empty;
            txtDescription.Text = string.Empty;
            nUpUnit.Value = 0;
            nUpPrice.Value = 0;
            nUpVatRate.Value = 0;
            chkIsBlocked.Checked = false;
            txtName.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void SaveItem()
        {
            Item item = new Item();
            item.Id = id;
            item.Name = txtName.Text;
            item.CategoryId = Convert.ToInt32(cboCategory.SelectedValue);
            item.Description = txtDescription.Text;
            item.Number = Convert.ToInt32(txtNumber.Text);
            item.Unit = Convert.ToInt32(nUpUnit.Value);
            item.Price = Convert.ToDouble(nUpPrice.Value);

            if (Convert.ToInt32(nUpVatRate.Value) > -1)
            {
                item.VatRate = Convert.ToDouble(nUpVatRate.Value);
            }
            else
            {
                item.VatRate = null;
            }
           
            item.IsBlocked = chkIsBlocked.Checked;
            if (txtPhotoFilePath.Text != string.Empty)
            {
                byte[] picture = GetPhoto(txtPhotoFilePath.Text);

                item.Photo = picture;
            }

            ItemBLL itemBLL = new ItemBLL();
            itemBLL.Save(item);
            LoadItem();
            ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }


        public byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = oFDPhoto.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtPhotoFilePath.Text = oFDPhoto.FileName;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
