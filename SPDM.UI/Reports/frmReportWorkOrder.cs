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
    public partial class frmReportWorkOrder : Form
    {
        public frmReportWorkOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptWorkOrder rptWorkOrder = new RptWorkOrder();
            ReportBLL reportBLL = new ReportBLL();
            
            string where = "";

            if (!string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                 where = "WorkOrderNo =  '" + txtWorkOrderNo.Text + "' ";
          
            }

            if (Convert.ToInt32(cmoParty.SelectedValue) > 0)
            {
                if (where != String.Empty)
                {
                    where = where + " AND ";
                }
                where = where + " PartyId =" + Convert.ToInt32(cmoParty.SelectedValue);
            }

            DataSet ds = reportBLL.GetWorkOrders(where);
            rptWorkOrder.DataSource = ds;
            rptWorkOrder.Parameters["WorkOrderNo"].Value = txtWorkOrderNo.Text;
            rptWorkOrder.Parameters["Party"].Value = cmoParty.Text;

            rptWorkOrder.CreateDocument();
            documentViewer1.DocumentSource = rptWorkOrder;

        }

        private void LoadParty()
        {

            Party party = new Party();
            party.Id = 0;
            party.Name = "Please Select-";
            PartyBLL partyBLL = new PartyBLL();
            List<Party> parties = partyBLL.GetAll();
            cmoParty.DataSource = parties;
            parties.Insert(0, party);
            cmoParty.ValueMember = "Id";
            cmoParty.DisplayMember = "Name";

        }

        private void frmReportWorkOrder_Load(object sender, EventArgs e)
        {
            LoadParty();
        }
    }
}
