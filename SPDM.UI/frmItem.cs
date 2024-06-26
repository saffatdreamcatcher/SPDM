﻿using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmItem : Form
    {
       
        private int itemId = 0;

        public frmItem()
        {
            InitializeComponent();
        }

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
        }


        private void LoadItem()
        {
            ItemBLL itemBLL = new ItemBLL();
            List<Item> item = itemBLL.GetAll();
            gridControl1.DataSource = item;
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            
            LoadCategory();
            LoadItem();
        }

        

        //private void DeleteItem(int id)
        //{
        //    if (MessageBox.Show("Are you sure you want to delete the item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        ItemBLL itemBLL = new ItemBLL();
        //        itemBLL.Delete(id);
        //        LoadItem();
        //    }

        //}

        

        private void ClearField()
        {
            txtName.Text = string.Empty;
            //itemId = 0;
            cboCategory.SelectedValue = string.Empty;
            txtNumber.Text = string.Empty;
            txtDescription.Text = string.Empty;
            nUpUnit.Value = 0;
            nUpPrice.Value = 0;
            nUpVatRate.Value = 0;
            chkIsBlocked.Checked = false;
            txtPhotoFilePath.Text = string.Empty;
            pictureBox1.Image = null;
            txtName.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        
        private void SaveItem()
        {
            try
            {
                Item item = new Item();
                item.Id = itemId;
                item.Name = txtName.Text;
                item.CategoryId = Convert.ToInt32(cboCategory.SelectedValue);
                item.Description = txtDescription.Text;
                item.Number = txtNumber.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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
                Image file = Image.FromFile(oFDPhoto.FileName);
                pictureBox1.Image = file;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem()
        {
            itemId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            txtName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Name"));
            cboCategory.SelectedValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CategoryId"));
            txtNumber.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Number"));
            txtDescription.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Description"));
            nUpUnit.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Unit"));
            nUpPrice.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Price"));
            nUpVatRate.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("VatRate"));
            chkIsBlocked.Checked = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsBlocked"));
          

            ItemBLL itemBLL = new ItemBLL();
            Item item = itemBLL.GetById(itemId);
            if (item.Photo != null)
            {
                MemoryStream ms = new MemoryStream(item.Photo);
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }
        private void repositoryItemHyperLinkEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditItem();
        }

        private void DeleteItem()
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int itemId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                ItemBLL itemBLL = new ItemBLL();
                itemBLL.Delete(itemId);
                LoadItem();
            }
        }
        private void repositoryItemHyperLinkEdit2_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteItem();
        }
    }
}
