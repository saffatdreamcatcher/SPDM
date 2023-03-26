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
    public partial class frmFiscalYear : Form
    {
        private int fiscalYearId;
        public frmFiscalYear()
        {
            InitializeComponent();
        }

        private void LoadFiscalYear()
        {


            for (int i = 2000; i <= DateTime.Now.Year + 5; i++)
            {
                string fy = "June-July/" + i;
                comboBox1.Items.Add(fy);
            }

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

        private void SaveFiscalYear()
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
