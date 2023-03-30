namespace SPDM.UI
{
    partial class frmWorkOrderList
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(1103, 24);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(102, 29);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.workOrderBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(30, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1175, 357);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(SPDM.DLL.Entities.WorkOrder);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpdateTime,
            this.colUserId,
            this.colWorkOrderNo,
            this.colFiscalyear,
            this.colPartyId,
            this.colWorkOrderDate,
            this.colDeliveryDate,
            this.colTotalExvat,
            this.colTotalIncvat,
            this.colDiscount,
            this.colDiscountPercent,
            this.colVatPercent,
            this.colStatus,
            this.colNote,
            this.colId,
            this.colIsNew,
            this.colCreateTime,
            this.gcEdit,
            this.gcDelete});
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
            // colWorkOrderNo
            // 
            this.colWorkOrderNo.FieldName = "WorkOrderNo";
            this.colWorkOrderNo.MinWidth = 25;
            this.colWorkOrderNo.Name = "colWorkOrderNo";
            this.colWorkOrderNo.Visible = true;
            this.colWorkOrderNo.VisibleIndex = 0;
            this.colWorkOrderNo.Width = 94;
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
            // colWorkOrderDate
            // 
            this.colWorkOrderDate.FieldName = "WorkOrderDate";
            this.colWorkOrderDate.MinWidth = 25;
            this.colWorkOrderDate.Name = "colWorkOrderDate";
            this.colWorkOrderDate.Visible = true;
            this.colWorkOrderDate.VisibleIndex = 3;
            this.colWorkOrderDate.Width = 94;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.MinWidth = 25;
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 4;
            this.colDeliveryDate.Width = 94;
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
            this.colTotalIncvat.VisibleIndex = 5;
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
            this.colDiscountPercent.VisibleIndex = 6;
            this.colDiscountPercent.Width = 94;
            // 
            // colVatPercent
            // 
            this.colVatPercent.FieldName = "VatPercent";
            this.colVatPercent.MinWidth = 25;
            this.colVatPercent.Name = "colVatPercent";
            this.colVatPercent.Visible = true;
            this.colVatPercent.VisibleIndex = 7;
            this.colVatPercent.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 8;
            this.colStatus.Width = 94;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
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
            // gcEdit
            // 
            this.gcEdit.Caption = "Edit";
            this.gcEdit.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gcEdit.MinWidth = 25;
            this.gcEdit.Name = "gcEdit";
            this.gcEdit.Visible = true;
            this.gcEdit.VisibleIndex = 10;
            this.gcEdit.Width = 94;
            // 
            // gcDelete
            // 
            this.gcDelete.Caption = "Delete";
            this.gcDelete.MinWidth = 25;
            this.gcDelete.Name = "gcDelete";
            this.gcDelete.Visible = true;
            this.gcDelete.VisibleIndex = 11;
            this.gcDelete.Width = 94;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemHyperLinkEdit1.Caption = "Edit";
            this.repositoryItemHyperLinkEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "Edit";
            this.repositoryItemHyperLinkEdit1.NullValuePrompt = "Edit";
            this.repositoryItemHyperLinkEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmWorkOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 507);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAddNew);
            this.Name = "frmWorkOrderList";
            this.Text = "frmWorkOrderList";
            this.Load += new System.EventHandler(this.frmWorkOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalyear;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyId;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
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
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
    }
}