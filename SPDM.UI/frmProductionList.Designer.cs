namespace SPDM.UI
{
    partial class frmProductionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalExvat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIncvat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.productionBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(25, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1330, 632);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataSource = typeof(SPDM.DLL.Entities.Production);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpdateTime,
            this.colUserId,
            this.colProductionNo,
            this.colFiscalyear,
            this.colPartyId,
            this.colWorkOrderId,
            this.colWorkOrderDate,
            this.colTotalExvat,
            this.colTotalIncvat,
            this.colDiscount,
            this.colDiscountPercent,
            this.colVatPercent,
            this.colStatus,
            this.colNote,
            this.colId,
            this.colIsNew,
            this.colCreateTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            this.gridView1.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridView1.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.FieldName = "UpdateTime";
            this.colUpdateTime.MinWidth = 25;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Width = 94;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 25;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 94;
            // 
            // colProductionNo
            // 
            this.colProductionNo.FieldName = "ProductionNo";
            this.colProductionNo.MinWidth = 25;
            this.colProductionNo.Name = "colProductionNo";
            this.colProductionNo.Visible = true;
            this.colProductionNo.VisibleIndex = 0;
            this.colProductionNo.Width = 94;
            // 
            // colFiscalyear
            // 
            this.colFiscalyear.FieldName = "Fiscalyear";
            this.colFiscalyear.MinWidth = 25;
            this.colFiscalyear.Name = "colFiscalyear";
            this.colFiscalyear.Visible = true;
            this.colFiscalyear.VisibleIndex = 1;
            this.colFiscalyear.Width = 94;
            // 
            // colPartyId
            // 
            this.colPartyId.FieldName = "PartyId";
            this.colPartyId.MinWidth = 25;
            this.colPartyId.Name = "colPartyId";
            this.colPartyId.Visible = true;
            this.colPartyId.VisibleIndex = 2;
            this.colPartyId.Width = 94;
            // 
            // colWorkOrderId
            // 
            this.colWorkOrderId.FieldName = "WorkOrderId";
            this.colWorkOrderId.MinWidth = 25;
            this.colWorkOrderId.Name = "colWorkOrderId";
            this.colWorkOrderId.Width = 94;
            // 
            // colWorkOrderDate
            // 
            this.colWorkOrderDate.FieldName = "WorkOrderDate";
            this.colWorkOrderDate.MinWidth = 25;
            this.colWorkOrderDate.Name = "colWorkOrderDate";
            this.colWorkOrderDate.Visible = true;
            this.colWorkOrderDate.VisibleIndex = 3;
            this.colWorkOrderDate.Width = 94;
            // 
            // colTotalExvat
            // 
            this.colTotalExvat.FieldName = "TotalExvat";
            this.colTotalExvat.MinWidth = 25;
            this.colTotalExvat.Name = "colTotalExvat";
            this.colTotalExvat.Width = 94;
            // 
            // colTotalIncvat
            // 
            this.colTotalIncvat.FieldName = "TotalIncvat";
            this.colTotalIncvat.MinWidth = 25;
            this.colTotalIncvat.Name = "colTotalIncvat";
            this.colTotalIncvat.Visible = true;
            this.colTotalIncvat.VisibleIndex = 4;
            this.colTotalIncvat.Width = 94;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 25;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 94;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 25;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 5;
            this.colDiscountPercent.Width = 94;
            // 
            // colVatPercent
            // 
            this.colVatPercent.FieldName = "VatPercent";
            this.colVatPercent.MinWidth = 25;
            this.colVatPercent.Name = "colVatPercent";
            this.colVatPercent.Visible = true;
            this.colVatPercent.VisibleIndex = 6;
            this.colVatPercent.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            this.colStatus.Width = 94;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 8;
            this.colNote.Width = 94;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colIsNew
            // 
            this.colIsNew.FieldName = "IsNew";
            this.colIsNew.MinWidth = 25;
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.OptionsColumn.ReadOnly = true;
            this.colIsNew.Width = 94;
            // 
            // colCreateTime
            // 
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.MinWidth = 25;
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.OptionsColumn.ReadOnly = true;
            this.colCreateTime.Width = 94;
            // 
            // frmProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 692);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmProductionList";
            this.Text = "frmProductionList";
            this.Load += new System.EventHandler(this.frmProductionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalyear;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyId;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalExvat;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIncvat;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colVatPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNew;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
    }
}