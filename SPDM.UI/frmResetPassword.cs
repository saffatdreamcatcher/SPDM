using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmResetPassword : Form
    {
        private int userId;
        public frmResetPassword()
        {
            InitializeComponent();
        }

        public void ShowDialog(int UserId)
        {
            userId = UserId;
            this.ShowDialog();

        }

        private Boolean IsFormValid()
        {
            ePResetPassword.Clear();
            Boolean iv = true;

            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Focus();
                ePResetPassword.SetError(txtNewPassword, "New Password cant be empty!");
                iv = false;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                ePResetPassword.SetError(txtNewPassword, "Confirm Password cant be empty!");
                iv = false;
            }
           
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                txtNewPassword.Focus();
                ePResetPassword.SetError(txtNewPassword, "NewPassword and ConfirmPassword doesnt match, can't Reset Password!");
                iv = false;
            }
            return iv;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                UserBLL userBLL = new UserBLL();
                User user = userBLL.GetById(userId);
                user.Password = txtConfirmPassword.Text;
                userBLL.Save(user);
                MessageBox.Show("Password Reset Successfully!");
              
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
