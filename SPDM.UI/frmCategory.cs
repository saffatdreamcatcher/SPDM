﻿using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            pictureBox1.Image = null;
            categoryId = 0;
            txtName.Focus();
        }

        private void LoadCategory()
        {
            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> category = categoryBLL.GetAll();
            gridControl1.DataSource = category;
        }

        private Boolean IsCategoryValid()
        {
            epCategory.Clear();
            Boolean iv = true;

            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                epCategory.SetError(txtName, "Can't empty");
                iv = false;
            }

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                CategoryBLL categoryBLL = new CategoryBLL();
                string whereClause = "Name= '" + txtName.Text + "'";

                if (categoryId > 0)
                {
                    whereClause += " and Id !=" + categoryId;
                }
              bool categoryExist =  categoryBLL.IsExist(whereClause);
                if (categoryExist)
                {
                    txtName.Focus();
                    epCategory.SetError(txtName, "Name already exists!");
                    iv = false;
                }
            }
            return iv;
        }

        private void SaveCategory()
        {
            try
            {

                if (IsCategoryValid())
                {

                    Category category = new Category();
                    category.Id = categoryId;
                    category.Name = txtName.Text;
                    category.Description = txtDescription.Text;
                    if (txtPhotoFilePath.Text != string.Empty)
                    {
                        byte[] picture = GetPhoto(txtPhotoFilePath.Text);

                        category.Photo = picture;
                    }


                    CategoryBLL categoryBLL = new CategoryBLL();
                    categoryBLL.Save(category);

                    LoadCategory();

                    ClearField();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCategory();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCategory()
        {
            categoryId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            txtName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Name"));
            txtDescription.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Description"));

            CategoryBLL categoryBLL = new CategoryBLL();
            Category category = categoryBLL.GetById(categoryId);
            if (category.Photo != null)
            {
                MemoryStream ms = new MemoryStream(category.Photo);
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }

        private void repositoryItemHyperLinkEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditCategory();
        }

        private void DeleteCategory()
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int categoryId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                CategoryBLL categoryBLL = new CategoryBLL();
                categoryBLL.Delete(categoryId);
                LoadCategory();
            }
        }
        private void repositoryItemHyperLinkEdit2_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteCategory();
        }
    }
}