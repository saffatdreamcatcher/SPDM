using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System.IO;

namespace SPDM.UI
{
    public partial class frmProfile : Form
    {
        private int profileId;
        public frmProfile()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            ProfileBLL profileBLL = new ProfileBLL();
            Profile profile = profileBLL.GetByUserId(Global.Userid);
            profileId = profile.Id;
            txtName.Text = profile.Name;
            txtAddress.Text = profile.Address;
            txtEmail.Text = profile.Email;
            txtdesignation.Text = profile.Designation;
            txtPhone.Text = profile.Phone;
            txtMobileNo.Text = profile.MobileNo;
            if (profile.Photo != null)
            {
                MemoryStream ms = new MemoryStream(profile.Photo);
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }

        private void SaveProfile()
        {
            Profile profile = new Profile();
            profile.Id = profileId;
            profile.UserId = Global.Userid;
            profile.Name = txtName.Text;
            profile.Address = txtAddress.Text;
            profile.Designation = txtdesignation.Text;
            profile.Email = txtEmail.Text;
            profile.Phone = txtPhone.Text;
            profile.MobileNo = txtMobileNo.Text;
            if (txtPhotoPath.Text != string.Empty)
            {
                byte[] picture = GetPhoto(txtPhotoPath.Text);

                profile.Photo = picture;
            }

            ProfileBLL profileBLL = new ProfileBLL();
            profileBLL.Save(profile);
            profileId = profile.Id;

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
                txtPhotoPath.Text = oFDPhoto.FileName;
                Image file = Image.FromFile(oFDPhoto.FileName);
                pictureBox1.Image = file;
            }
        }

    }
}
