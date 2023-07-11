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
    public partial class frmParty : Form
    {
        private int partyId;

        public frmParty()
        {
            InitializeComponent();
        }

        private void ClearField()
        {
            txtName.Text = string.Empty;
            txtAccount.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNote.Text = string.Empty;
            partyId = 0;
            txtName.Focus();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void LoadParty()
        {
            gvParty.AutoGenerateColumns = false;
            PartyBLL partyBLL = new PartyBLL();
            List<Party> party = partyBLL.GetAll();
            gvParty.DataSource = party;

        }

        private Boolean IsFormValid()
        {
            epParty.Clear();
            Boolean iv = true;

            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                epParty.SetError(txtName, "Can't empty");
                iv = false;
            }
            return iv;
        }

        private void SaveParty()
        {

            if (IsFormValid())
            {

                Party party = new Party();
                party.Id = partyId;
                party.Name = txtName.Text;
                party.Account = txtAccount.Text;
                party.Address = txtAddress.Text;
                party.City = txtCity.Text;
                party.PostalCode = txtPostalCode.Text;
                party.Country = txtCountry.Text;
                party.PhoneNo = txtPhoneNo.Text;
                party.MobileNo = txtMobileNo.Text;  
                party.Fax = txtFax.Text;
                party.Email = txtEmail.Text;
                party.Note = txtNote.Text;

                PartyBLL partyBLL = new PartyBLL();
                partyBLL.Save(party);
                LoadParty();
                ClearField();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveParty();
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                partyId = Convert.ToInt32(gvParty.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[1].Value);
                txtAccount.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[4].Value);
                txtAddress.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[5].Value);
                txtCity.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[6].Value);
                txtPostalCode.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[7].Value);
                txtCountry.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[8].Value);
                txtPhoneNo.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[9].Value);
                txtMobileNo.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[10].Value);
                txtFax.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[11].Value);
                txtEmail.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[12].Value);
                txtNote.Text = Convert.ToString(gvParty.Rows[e.RowIndex].Cells[13].Value);
            }
            else if (e.ColumnIndex == 16)
            {
                var id = Convert.ToInt32(gvParty.Rows[e.RowIndex].Cells[0].Value);
                DeleteParty(id);
            }
        }

        private void DeleteParty(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Party?", "Delete Party", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                PartyBLL partyBLL = new PartyBLL();
                partyBLL.Delete(id);
                LoadParty();
            }

        }

        private void gvParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParty_Load(object sender, EventArgs e)
        {
            LoadParty();
        }
    }
}
