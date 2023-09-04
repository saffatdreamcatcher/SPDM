using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }


        private Boolean IsFormValid()
        {
            epChangePassword.Clear();
            Boolean iv = true;

            UserBLL userBLL = new UserBLL();
            bool isExist = userBLL.UserExist(Global.Username, txtOldPassword.Text);
            if (String.IsNullOrEmpty(txtOldPassword.Text))
            {
                txtOldPassword.Focus();
                epChangePassword.SetError(txtOldPassword, "Old Password cant be empty!");
                iv = false;
            }
            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Focus();
                epChangePassword.SetError(txtNewPassword, "New Password cant be empty!");
                iv = false;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                epChangePassword.SetError(txtConfirmPassword, "Confirm Password cant be empty!");
                iv = false;
            }
            if (!isExist)
            {
                txtOldPassword.Focus();
                epChangePassword.SetError(txtOldPassword, "Old Password doesnt match");
                iv = false;
            }

            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            { 
                txtNewPassword.Focus();
                epChangePassword.SetError(txtNewPassword, "NewPassword and OldPassword doesnt match");
                iv = false;
            }
            return iv;
        }

        private void ChangePassword()
        {
            if (IsFormValid())
            {

                UserBLL userBLL = new UserBLL();
                userBLL.ChangePassword(Global.Userid, txtNewPassword.Text);
                txtOldPassword.Text = string.Empty;
                txtNewPassword.Text = String.Empty;
                txtConfirmPassword.Text = String.Empty;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
    }
}
