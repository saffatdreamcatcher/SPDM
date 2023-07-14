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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.gCAddToStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddToStock = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.cmoParty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProduction = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dTPFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dTPToDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.productionBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.gridControl1.Location = new System.Drawing.Point(14, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAddToStock,
            this.repositoryItemHyperLinkEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1385, 408);
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
            this.colCreateTime,
            this.gCAddToStock,
            this.gcDelete});
            this.gridView1.DetailHeight = 2600;
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
            this.colUpdateTime.MinWidth = 120;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Width = 694;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 120;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 694;
            // 
            // colProductionNo
            // 
            this.colProductionNo.FieldName = "ProductionNo";
            this.colProductionNo.MinWidth = 186;
            this.colProductionNo.Name = "colProductionNo";
            this.colProductionNo.Visible = true;
            this.colProductionNo.VisibleIndex = 0;
            this.colProductionNo.Width = 694;
            // 
            // colFiscalyear
            // 
            this.colFiscalyear.FieldName = "Fiscalyear";
            this.colFiscalyear.MinWidth = 140;
            this.colFiscalyear.Name = "colFiscalyear";
            this.colFiscalyear.Visible = true;
            this.colFiscalyear.VisibleIndex = 1;
            this.colFiscalyear.Width = 694;
            // 
            // colPartyId
            // 
            this.colPartyId.FieldName = "PartyId";
            this.colPartyId.MinWidth = 186;
            this.colPartyId.Name = "colPartyId";
            this.colPartyId.Width = 694;
            // 
            // colWorkOrderId
            // 
            this.colWorkOrderId.FieldName = "WorkOrderId";
            this.colWorkOrderId.MinWidth = 120;
            this.colWorkOrderId.Name = "colWorkOrderId";
            this.colWorkOrderId.Width = 694;
            // 
            // colWorkOrderDate
            // 
            this.colWorkOrderDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colWorkOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWorkOrderDate.FieldName = "WorkOrderDate";
            this.colWorkOrderDate.MinWidth = 120;
            this.colWorkOrderDate.Name = "colWorkOrderDate";
            this.colWorkOrderDate.Visible = true;
            this.colWorkOrderDate.VisibleIndex = 2;
            this.colWorkOrderDate.Width = 694;
            // 
            // colTotalExvat
            // 
            this.colTotalExvat.FieldName = "TotalExvat";
            this.colTotalExvat.MinWidth = 120;
            this.colTotalExvat.Name = "colTotalExvat";
            this.colTotalExvat.Width = 694;
            // 
            // colTotalIncvat
            // 
            this.colTotalIncvat.FieldName = "TotalIncvat";
            this.colTotalIncvat.MinWidth = 140;
            this.colTotalIncvat.Name = "colTotalIncvat";
            this.colTotalIncvat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TotalIncvat", "{0}")});
            this.colTotalIncvat.Visible = true;
            this.colTotalIncvat.VisibleIndex = 3;
            this.colTotalIncvat.Width = 694;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 140;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 694;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 140;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 4;
            this.colDiscountPercent.Width = 694;
            // 
            // colVatPercent
            // 
            this.colVatPercent.FieldName = "VatPercent";
            this.colVatPercent.MinWidth = 120;
            this.colVatPercent.Name = "colVatPercent";
            this.colVatPercent.Visible = true;
            this.colVatPercent.VisibleIndex = 5;
            this.colVatPercent.Width = 694;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 120;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 694;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 120;
            this.colNote.Name = "colNote";
            this.colNote.Width = 694;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 120;
            this.colId.Name = "colId";
            this.colId.Width = 694;
            // 
            // colIsNew
            // 
            this.colIsNew.FieldName = "IsNew";
            this.colIsNew.MinWidth = 120;
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.OptionsColumn.ReadOnly = true;
            this.colIsNew.Width = 694;
            // 
            // colCreateTime
            // 
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.MinWidth = 120;
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.OptionsColumn.ReadOnly = true;
            this.colCreateTime.Width = 694;
            // 
            // gCAddToStock
            // 
            this.gCAddToStock.ColumnEdit = this.btnAddToStock;
            this.gCAddToStock.MinWidth = 140;
            this.gCAddToStock.Name = "gCAddToStock";
            this.gCAddToStock.Visible = true;
            this.gCAddToStock.VisibleIndex = 6;
            this.gCAddToStock.Width = 555;
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.AutoHeight = false;
            this.btnAddToStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add To Stock", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAddToStock.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAddToStock.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAddToStock_ButtonPressed);
            // 
            // gcDelete
            // 
            this.gcDelete.Caption = "Delete";
            this.gcDelete.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gcDelete.MinWidth = 120;
            this.gcDelete.Name = "gcDelete";
            this.gcDelete.Visible = true;
            this.gcDelete.VisibleIndex = 7;
            this.gcDelete.Width = 284;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, editorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemHyperLinkEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemHyperLinkEdit1.Caption = "Delete";
            this.repositoryItemHyperLinkEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "Delete";
            this.repositoryItemHyperLinkEdit1.NullValuePrompt = "Delete";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit1_Click);
            // 
            // cmoParty
            // 
            this.cmoParty.FormattingEnabled = true;
            this.cmoParty.Location = new System.Drawing.Point(427, 55);
            this.cmoParty.Name = "cmoParty";
            this.cmoParty.Size = new System.Drawing.Size(215, 24);
            this.cmoParty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Party";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Production No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(969, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "From Date";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1308, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(139, 56);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(198, 22);
            this.txtProduction.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1397, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.EditValue = null;
            this.dTPFromDate.Location = new System.Drawing.Point(745, 55);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dTPFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPFromDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPFromDate.Size = new System.Drawing.Size(211, 22);
            this.dTPFromDate.TabIndex = 37;
            // 
            // dTPToDate
            // 
            this.dTPToDate.EditValue = null;
            this.dTPToDate.Location = new System.Drawing.Point(1057, 54);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dTPToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPToDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPToDate.Size = new System.Drawing.Size(226, 22);
            this.dTPToDate.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1029, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(724, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = ":";
            // 
            // frmProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1429, 639);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmoParty);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmProductionList";
            this.Text = "frmProductionList";
            this.Load += new System.EventHandler(this.frmProductionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.Columns.GridColumn gCAddToStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAddToStock;
        private System.Windows.Forms.ComboBox cmoParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProduction;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.DateEdit dTPFromDate;
        private DevExpress.XtraEditors.DateEdit dTPToDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}