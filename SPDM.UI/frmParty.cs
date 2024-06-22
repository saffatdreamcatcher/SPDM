using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
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
            PartyBLL partyBLL = new PartyBLL();
            List<Party> party = partyBLL.GetAll();
            gridControl1.DataSource = party;
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveParty();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParty_Load(object sender, EventArgs e)
        {
            LoadParty();
        }

        private void EditParty()
        {
            partyId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            txtName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Name"));
            txtAccount.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Account"));
            txtAddress.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Address"));
            txtCity.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("City"));
            txtPostalCode.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("PostalCode"));
            txtCountry.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Country"));
            txtMobileNo.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("MobileNo"));
            txtPhoneNo.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("PhoneNo"));
            txtFax.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Fax"));
            txtEmail.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Email"));
            txtNote.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Note"));

            PartyBLL partyBLL = new PartyBLL();
            Party party = partyBLL.GetById(partyId);
        }
        private void repositoryItemHyperLinkEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditParty();
        }

        private void DeleteParty()
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int partyId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                PartyBLL partyBLL = new PartyBLL();
                partyBLL.Delete(partyId);
                LoadParty();
            }
        }
        private void repositoryItemHyperLinkEdit2_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteParty();
        }
    }
}
