using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmFiscalYear : Form
    {
        private int fiscalYearId;
        public frmFiscalYear()
        {
            InitializeComponent();
        }

        private void LoadFiscalYear()
        {

            // ComboBox Item Created And Shown
            for (int i = 2000; i <= DateTime.Now.Year + 5; i++)
            {
                string fy = "June-July/" + i;
                comboBox1.Items.Add(fy);
            }

            // Get FiscalYear Of Current LoggedIn User And Assign It To ComboBox
            // FiscalYear.Id Is Assigned To fiscalYearId
            string where = "UserId = " + Global.Userid;
            FiscalYearBLL fiscalYearBLL = new FiscalYearBLL();
            List<FiscalYear> fiscalYears = fiscalYearBLL.GetAll(where);
            if (fiscalYears.Count > 0)
            {
                FiscalYear fiscalYear = fiscalYears[0];
                comboBox1.SelectedItem = fiscalYear.Year;
                fiscalYearId = fiscalYear.Id;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFiscalYear();
        }

        private void frmFiscalYear_Load(object sender, EventArgs e)
        {
            LoadFiscalYear();
        }

        private bool isFiscalYearValid()
        {
            Boolean iv = true;
            if (Convert.ToInt32(comboBox1.SelectedIndex) == -1)
            {
                comboBox1.Focus();
                eP.SetError(comboBox1, "Fisacl Year Can't be empty");
                iv = false;
            }
            return iv;
        }

        private void SaveFiscalYear()
        {
            bool isValid = isFiscalYearValid();
            if (isValid)
            {
                FiscalYear fiscalYear = new FiscalYear();
                fiscalYear.Id = fiscalYearId;
                fiscalYear.UserId = Global.Userid;
                fiscalYear.Year = comboBox1.SelectedItem.ToString();

                FiscalYearBLL fiscalYearBLL = new FiscalYearBLL();
                fiscalYearBLL.Save(fiscalYear);
                fiscalYearId = fiscalYear.Id;
                Global.FiscalYear = fiscalYear.Year;
            }

        }
    }
}
