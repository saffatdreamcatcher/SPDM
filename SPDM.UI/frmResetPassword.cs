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
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            User user = userBLL.GetById(userId);
            user.Password = txtConfirmPassword.Text;
            userBLL.Save(user);
        }
    }
}
