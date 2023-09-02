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
    public partial class frmUser : Form
    {
        private int userId;
        private int id;

        public frmUser()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
           
            chkIsActive.Checked = false;
            chkLockOutEnabled.Checked = false;
            userId = 0;
            txtUserName.Focus();
            txtPassword.Focus();
        }

        private void LoadUser()
        {
            gvUser.AutoGenerateColumns = false;
            UserBLL userBLL = new UserBLL();
            List<User> users = userBLL.GetAll();
            gvUser.DataSource = users;

        }

        private Boolean IsFormValid()
        {
            epUser.Clear();
            Boolean iv = true;

            if (txtUserName.Text == string.Empty) 
            {
                txtUserName.Focus();
                epUser.SetError(txtUserName, "Can't empty");
                iv = false;
            }
            return iv;

            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Focus();
                epUser.SetError(txtPassword, "Can't empty");
                iv = false;
            }
            return iv;
        }


        private void SaveUser()
        {
            if (IsFormValid())
            {
                User user = new User();
                user.Id = userId;
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.LockoutEnabled = chkLockOutEnabled.Checked;
                user.LockoutEndDate = null;
                user.AccessFailedCount = 0;
                user.IsActive = chkIsActive.Checked;

                UserBLL userBLL = new UserBLL();
                userBLL.Save(user);

                LoadUser();
                ClearField();
            }
        }

        private void DeleteUser(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                UserBLL userBLL = new UserBLL();
                userBLL.MarkAsInactive(id);
                LoadUser();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                userId = Convert.ToInt32(gvUser.Rows[e.RowIndex].Cells[0].Value);
                txtUserName.Text = Convert.ToString(gvUser.Rows[e.RowIndex].Cells[2].Value);
                txtPassword.Text = Convert.ToString(gvUser.Rows[e.RowIndex].Cells[3].Value);
                chkLockOutEnabled.Checked = false;
                chkIsActive.Checked = false;
               

            }
            else if (e.ColumnIndex == 10)
            {
                var id = Convert.ToInt32(gvUser.Rows[e.RowIndex].Cells[0].Value);
                DeleteUser(id);
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
