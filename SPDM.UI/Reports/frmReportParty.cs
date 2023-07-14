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

namespace SPDM.UI.Reports
{
    public partial class frmReportParty : Form
    {
        public frmReportParty()
        {
            InitializeComponent();
        }
        private void LoadParty()
        {
            Party party = new Party();
            RptParty rptParty = new RptParty();

            PartyBLL partyBLL = new PartyBLL();
            List<Party> parties = new List<Party>();

            parties = partyBLL.GetAll();
            rptParty.DataSource = parties;

            rptParty.Parameters["PartyName"].Value = "Ocean";

            rptParty.CreateDocument();


            documentViewer1.DocumentSource = rptParty;

        }

        private void frmReportParty_Load(object sender, EventArgs e)
        {
            LoadParty();
        }
    }
}
