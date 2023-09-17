namespace SPDM.UI
{
    partial class frmSaleList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChallanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalExvat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIncvat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtChallanNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.saleBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(30);
            this.gridControl1.Location = new System.Drawing.Point(145, 153);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(30);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1250, 483);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SPDM.DLL.Entities.Sale);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpdateTime,
            this.colUserId,
            this.colWorkOrderId,
            this.colFiscalyear,
            this.colPartyId,
            this.colChallanNo,
            this.colSaleDate,
            this.colTotalExvat,
            this.colTotalIncvat,
            this.colDiscount,
            this.colDiscountPercent,
            this.colVatPercent,
            this.colDeliveryAddress,
            this.colDeliveryDate,
            this.colNote,
            this.colId,
            this.colIsNew,
            this.colCreateTime,
            this.colUserId1,
            this.gcDelete});
            this.gridView1.DetailHeight = 3250;
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
            this.colUpdateTime.MinWidth = 70;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Width = 867;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 70;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 867;
            // 
            // colWorkOrderId
            // 
            this.colWorkOrderId.FieldName = "WorkOrderId";
            this.colWorkOrderId.MinWidth = 70;
            this.colWorkOrderId.Name = "colWorkOrderId";
            this.colWorkOrderId.Width = 867;
            // 
            // colFiscalyear
            // 
            this.colFiscalyear.FieldName = "Fiscalyear";
            this.colFiscalyear.MinWidth = 100;
            this.colFiscalyear.Name = "colFiscalyear";
            this.colFiscalyear.Visible = true;
            this.colFiscalyear.VisibleIndex = 0;
            this.colFiscalyear.Width = 867;
            // 
            // colPartyId
            // 
            this.colPartyId.FieldName = "PartyId";
            this.colPartyId.MinWidth = 80;
            this.colPartyId.Name = "colPartyId";
            this.colPartyId.Width = 867;
            // 
            // colChallanNo
            // 
            this.colChallanNo.FieldName = "ChallanNo";
            this.colChallanNo.MinWidth = 100;
            this.colChallanNo.Name = "colChallanNo";
            this.colChallanNo.Visible = true;
            this.colChallanNo.VisibleIndex = 1;
            this.colChallanNo.Width = 867;
            // 
            // colSaleDate
            // 
            this.colSaleDate.FieldName = "SaleDate";
            this.colSaleDate.MinWidth = 80;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.Visible = true;
            this.colSaleDate.VisibleIndex = 2;
            this.colSaleDate.Width = 867;
            // 
            // colTotalExvat
            // 
            this.colTotalExvat.FieldName = "TotalExvat";
            this.colTotalExvat.MinWidth = 80;
            this.colTotalExvat.Name = "colTotalExvat";
            this.colTotalExvat.Width = 867;
            // 
            // colTotalIncvat
            // 
            this.colTotalIncvat.FieldName = "TotalIncvat";
            this.colTotalIncvat.MinWidth = 80;
            this.colTotalIncvat.Name = "colTotalIncvat";
            this.colTotalIncvat.Visible = true;
            this.colTotalIncvat.VisibleIndex = 3;
            this.colTotalIncvat.Width = 867;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 80;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 867;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 80;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 4;
            this.colDiscountPercent.Width = 867;
            // 
            // colVatPercent
            // 
            this.colVatPercent.FieldName = "VatPercent";
            this.colVatPercent.MinWidth = 80;
            this.colVatPercent.Name = "colVatPercent";
            this.colVatPercent.Visible = true;
            this.colVatPercent.VisibleIndex = 5;
            this.colVatPercent.Width = 867;
            // 
            // colDeliveryAddress
            // 
            this.colDeliveryAddress.FieldName = "DeliveryAddress";
            this.colDeliveryAddress.MinWidth = 80;
            this.colDeliveryAddress.Name = "colDeliveryAddress";
            this.colDeliveryAddress.Visible = true;
            this.colDeliveryAddress.VisibleIndex = 6;
            this.colDeliveryAddress.Width = 867;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.MinWidth = 80;
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 7;
            this.colDeliveryDate.Width = 867;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 80;
            this.colNote.Name = "colNote";
            this.colNote.Width = 867;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 80;
            this.colId.Name = "colId";
            this.colId.Width = 867;
            // 
            // colIsNew
            // 
            this.colIsNew.FieldName = "IsNew";
            this.colIsNew.MinWidth = 80;
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.OptionsColumn.ReadOnly = true;
            this.colIsNew.Width = 867;
            // 
            // colCreateTime
            // 
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.MinWidth = 80;
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.OptionsColumn.ReadOnly = true;
            this.colCreateTime.Width = 867;
            // 
            // colUserId1
            // 
            this.colUserId1.FieldName = "UserId";
            this.colUserId1.MinWidth = 80;
            this.colUserId1.Name = "colUserId1";
            this.colUserId1.Width = 867;
            // 
            // gcDelete
            // 
            this.gcDelete.Caption = "Delete";
            this.gcDelete.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gcDelete.MinWidth = 80;
            this.gcDelete.Name = "gcDelete";
            this.gcDelete.Visible = true;
            this.gcDelete.VisibleIndex = 8;
            this.gcDelete.Width = 609;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemHyperLinkEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemHyperLinkEdit1.Caption = "Delete";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemHyperLinkEdit1.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemHyperLinkEdit1_ButtonPressed);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(1289, 82);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 38);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.Location = new System.Drawing.Point(145, 93);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(204, 22);
            this.txtChallanNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Challan No";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(503, 93);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(204, 22);
            this.txtDeliveryAddress.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Delivery Address";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(725, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 38);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1403, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(45, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sale List";
            // 
            // frmSaleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1434, 662);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChallanNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmSaleList";
            this.Load += new System.EventHandler(this.frmSaleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalyear;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyId;
        private DevExpress.XtraGrid.Columns.GridColumn colChallanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalExvat;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIncvat;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colVatPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNew;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
        private System.Windows.Forms.Button btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId1;
        private System.Windows.Forms.TextBox txtChallanNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}