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
    public partial class frmCategory : Form
    {
        private int categoryId;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPhotoFilePath.Text = string.Empty;
            categoryId = 0;
            txtName.Focus();
        }

        private void LoadCategory()
        {
            gvCategory.AutoGenerateColumns = false;
            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> category = categoryBLL.GetAll();
            gvCategory.DataSource = category;

        }

        private Boolean IsFormValid()
        {
            epCategory.Clear();
            Boolean iv = true;

            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                epCategory.SetError(txtName, "Can't empty");
                iv = false;
            }
            return iv;
        }

        private void SaveCategory()
        {
            if (IsFormValid())
            {
                Category category = new Category();
                category.Id = categoryId;
                category.Name = txtName.Text;
                category.Description = txtDescription.Text;
                byte[] picture = GetPhoto(txtPhotoFilePath.Text);
                category.Photo = picture;


                CategoryBLL categoryBLL = new CategoryBLL();
                categoryBLL.Save(category);

                LoadCategory();
                ClearField();
            }
        }

        public static byte[] GetPhoto(string filePath)
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

        private void DeleteCategory(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                CategoryBLL categoryBLL = new CategoryBLL();
                categoryBLL.Delete(id);
                LoadCategory();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCategory();
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                categoryId = Convert.ToInt32(gvCategory.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvCategory.Rows[e.RowIndex].Cells[2].Value);
                txtDescription.Text = Convert.ToString(gvCategory.Rows[e.RowIndex].Cells[3].Value);


            }
            else if (e.ColumnIndex == 7)
            {
                var id = Convert.ToInt32(gvCategory.Rows[e.RowIndex].Cells[0].Value);
                DeleteCategory(id);
            }
        }

        

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }
    }
}