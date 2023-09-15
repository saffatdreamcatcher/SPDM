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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gC1Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteStock = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
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
            this.gridControl1.DataSource = this.productionBindingSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(75);
            this.gridControl1.Location = new System.Drawing.Point(139, 170);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(75);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAddToStock,
            this.btnDeleteStock});
            this.gridControl1.Size = new System.Drawing.Size(1221, 446);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productionBindingSource1
            // 
            this.productionBindingSource1.DataSource = typeof(SPDM.DLL.Entities.Production);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpdateTime,
            this.colUserId,
            this.colProductionNo,
            this.colPartyName,
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
            this.gC1Delete});
            this.gridView1.DetailHeight = 7932;
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
            this.colUpdateTime.MinWidth = 10;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Width = 10;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 10;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 10;
            // 
            // colProductionNo
            // 
            this.colProductionNo.FieldName = "ProductionNo";
            this.colProductionNo.MinWidth = 10;
            this.colProductionNo.Name = "colProductionNo";
            this.colProductionNo.Visible = true;
            this.colProductionNo.VisibleIndex = 0;
            this.colProductionNo.Width = 129;
            // 
            // colPartyName
            // 
            this.colPartyName.FieldName = "PartyName";
            this.colPartyName.MinWidth = 39;
            this.colPartyName.Name = "colPartyName";
            this.colPartyName.Visible = true;
            this.colPartyName.VisibleIndex = 1;
            this.colPartyName.Width = 167;
            // 
            // colFiscalyear
            // 
            this.colFiscalyear.FieldName = "Fiscalyear";
            this.colFiscalyear.MinWidth = 10;
            this.colFiscalyear.Name = "colFiscalyear";
            this.colFiscalyear.Visible = true;
            this.colFiscalyear.VisibleIndex = 2;
            this.colFiscalyear.Width = 125;
            // 
            // colPartyId
            // 
            this.colPartyId.FieldName = "PartyId";
            this.colPartyId.MinWidth = 10;
            this.colPartyId.Name = "colPartyId";
            this.colPartyId.Width = 10;
            // 
            // colWorkOrderId
            // 
            this.colWorkOrderId.FieldName = "WorkOrderId";
            this.colWorkOrderId.MinWidth = 10;
            this.colWorkOrderId.Name = "colWorkOrderId";
            this.colWorkOrderId.Width = 10;
            // 
            // colWorkOrderDate
            // 
            this.colWorkOrderDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colWorkOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWorkOrderDate.FieldName = "WorkOrderDate";
            this.colWorkOrderDate.MinWidth = 10;
            this.colWorkOrderDate.Name = "colWorkOrderDate";
            this.colWorkOrderDate.Visible = true;
            this.colWorkOrderDate.VisibleIndex = 3;
            this.colWorkOrderDate.Width = 129;
            // 
            // colTotalExvat
            // 
            this.colTotalExvat.FieldName = "TotalExvat";
            this.colTotalExvat.MinWidth = 10;
            this.colTotalExvat.Name = "colTotalExvat";
            this.colTotalExvat.Width = 10;
            // 
            // colTotalIncvat
            // 
            this.colTotalIncvat.FieldName = "TotalIncvat";
            this.colTotalIncvat.MinWidth = 10;
            this.colTotalIncvat.Name = "colTotalIncvat";
            this.colTotalIncvat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TotalIncvat", "{0}")});
            this.colTotalIncvat.Visible = true;
            this.colTotalIncvat.VisibleIndex = 4;
            this.colTotalIncvat.Width = 56;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 10;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 10;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 10;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 6;
            this.colDiscountPercent.Width = 60;
            // 
            // colVatPercent
            // 
            this.colVatPercent.FieldName = "VatPercent";
            this.colVatPercent.MinWidth = 10;
            this.colVatPercent.Name = "colVatPercent";
            this.colVatPercent.Visible = true;
            this.colVatPercent.VisibleIndex = 7;
            this.colVatPercent.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 10;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 50;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 10;
            this.colNote.Name = "colNote";
            this.colNote.Width = 10;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 10;
            this.colId.Name = "colId";
            this.colId.Width = 10;
            // 
            // colIsNew
            // 
            this.colIsNew.FieldName = "IsNew";
            this.colIsNew.MinWidth = 10;
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.OptionsColumn.ReadOnly = true;
            this.colIsNew.Width = 10;
            // 
            // colCreateTime
            // 
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.MinWidth = 100;
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.OptionsColumn.ReadOnly = true;
            this.colCreateTime.Visible = true;
            this.colCreateTime.VisibleIndex = 5;
            this.colCreateTime.Width = 121;
            // 
            // gCAddToStock
            // 
            this.gCAddToStock.ColumnEdit = this.btnAddToStock;
            this.gCAddToStock.MaxWidth = 100;
            this.gCAddToStock.MinWidth = 10;
            this.gCAddToStock.Name = "gCAddToStock";
            this.gCAddToStock.Visible = true;
            this.gCAddToStock.VisibleIndex = 8;
            this.gCAddToStock.Width = 100;
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.AutoHeight = false;
            this.btnAddToStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add To Stock", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAddToStock.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAddToStock.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAddToStock_ButtonPressed);
            // 
            // gC1Delete
            // 
            this.gC1Delete.Caption = "Delete";
            this.gC1Delete.ColumnEdit = this.btnDeleteStock;
            this.gC1Delete.MaxWidth = 80;
            this.gC1Delete.MinWidth = 25;
            this.gC1Delete.Name = "gC1Delete";
            this.gC1Delete.Visible = true;
            this.gC1Delete.VisibleIndex = 9;
            this.gC1Delete.Width = 80;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.AutoHeight = false;
            this.btnDeleteStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteStock.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteStock.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteStock_ButtonPressed);
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataSource = typeof(SPDM.DLL.Entities.Production);
            // 
            // cmoParty
            // 
            this.cmoParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoParty.FormattingEnabled = true;
            this.cmoParty.Location = new System.Drawing.Point(389, 59);
            this.cmoParty.Name = "cmoParty";
            this.cmoParty.Size = new System.Drawing.Size(188, 24);
            this.cmoParty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Party";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Production No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "To ProductionDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "From ProductionDate";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(139, 60);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(188, 22);
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
            this.dTPFromDate.Location = new System.Drawing.Point(738, 61);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(30);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dTPFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPFromDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPFromDate.Size = new System.Drawing.Size(153, 22);
            this.dTPFromDate.TabIndex = 37;
            // 
            // dTPToDate
            // 
            this.dTPToDate.EditValue = null;
            this.dTPToDate.Location = new System.Drawing.Point(1039, 61);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(30);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dTPToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPToDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPToDate.Size = new System.Drawing.Size(169, 22);
            this.dTPToDate.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1021, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(723, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(19, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Production List";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(236, 104);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 36);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1429, 639);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
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
            this.Load += new System.EventHandler(this.frmProductionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource productionBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyName;
        private System.Windows.Forms.Button btnReset;
        private DevExpress.XtraGrid.Columns.GridColumn gC1Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteStock;
    }
}