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
    public partial class frmRole : Form
    {
        private int roleId;

        public frmRole()
        {
            InitializeComponent();
        }

        private void gvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }


        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtName.Text = string.Empty;
            roleId = 0;
            txtName.Focus();
        }

        private void LoadRole()
        {
            gvRole.AutoGenerateColumns = false;
            RoleBLL roleBLL = new RoleBLL();
            List<Role> category = roleBLL.GetAll();
            gvRole.DataSource = category;

        }

        private Boolean IsFormValid()
        {
            epRole.Clear();
            Boolean iv = true;

            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                epRole.SetError(txtName, "Can't empty");
                iv = false;
            }
            return iv;
        }

        private void SaveRole()
        {
            if (IsFormValid())
            {
                Role role = new Role();
                role.Id = roleId;
                role.Name = txtName.Text;

                RoleBLL roleBLL = new RoleBLL();
                roleBLL.Save(role);

                LoadRole();
                ClearField();
            }
        }

        private void DeleteRole(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Role?", "Delete Role", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                RoleBLL roleBLL = new RoleBLL();
                roleBLL.Delete(id);
                LoadRole();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRole();
        }


        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                roleId = Convert.ToInt32(gvRole.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvRole.Rows[e.RowIndex].Cells[1].Value);

            }
            else if (e.ColumnIndex == 5)
            {
                var id = Convert.ToInt32(gvRole.Rows[e.RowIndex].Cells[0].Value);
                DeleteRole(id);
            }
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
