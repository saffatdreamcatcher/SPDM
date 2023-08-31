namespace SPDM.UI
{
    partial class frmStockList
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
            this.gvStock = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiscalyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingQuantityInKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingQuantityInFKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityInKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityInFKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrum = new System.Windows.Forms.TextBox();
            this.txtCoil = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmoCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmoItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dTPFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dTPToDate = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStock
            // 
            this.gvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStock.AutoGenerateColumns = false;
            this.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.fiscalyearDataGridViewTextBoxColumn,
            this.drumDataGridViewTextBoxColumn,
            this.coilNoDataGridViewTextBoxColumn,
            this.dinDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.openingQuantityInKMDataGridViewTextBoxColumn,
            this.openingQuantityInFKMDataGridViewTextBoxColumn,
            this.currentQuantityInKMDataGridViewTextBoxColumn,
            this.currentQuantityInFKMDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.isNewDataGridViewCheckBoxColumn});
            this.gvStock.DataSource = this.stockBindingSource1;
            this.gvStock.Location = new System.Drawing.Point(12, 186);
            this.gvStock.Name = "gvStock";
            this.gvStock.RowHeadersWidth = 51;
            this.gvStock.RowTemplate.Height = 24;
            this.gvStock.Size = new System.Drawing.Size(1455, 341);
            this.gvStock.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Visible = false;
            this.createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateTimeDataGridViewTextBoxColumn
            // 
            this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            this.updateTimeDataGridViewTextBoxColumn.Visible = false;
            this.updateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            this.categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            this.itemIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiscalyearDataGridViewTextBoxColumn
            // 
            this.fiscalyearDataGridViewTextBoxColumn.DataPropertyName = "Fiscalyear";
            this.fiscalyearDataGridViewTextBoxColumn.HeaderText = "Fiscalyear";
            this.fiscalyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiscalyearDataGridViewTextBoxColumn.Name = "fiscalyearDataGridViewTextBoxColumn";
            this.fiscalyearDataGridViewTextBoxColumn.Width = 125;
            // 
            // drumDataGridViewTextBoxColumn
            // 
            this.drumDataGridViewTextBoxColumn.DataPropertyName = "Drum";
            this.drumDataGridViewTextBoxColumn.HeaderText = "Drum";
            this.drumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drumDataGridViewTextBoxColumn.Name = "drumDataGridViewTextBoxColumn";
            this.drumDataGridViewTextBoxColumn.Width = 70;
            // 
            // coilNoDataGridViewTextBoxColumn
            // 
            this.coilNoDataGridViewTextBoxColumn.DataPropertyName = "CoilNo";
            this.coilNoDataGridViewTextBoxColumn.HeaderText = "CoilNo";
            this.coilNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coilNoDataGridViewTextBoxColumn.Name = "coilNoDataGridViewTextBoxColumn";
            this.coilNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // dinDataGridViewTextBoxColumn
            // 
            this.dinDataGridViewTextBoxColumn.DataPropertyName = "Din";
            this.dinDataGridViewTextBoxColumn.HeaderText = "Din";
            this.dinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinDataGridViewTextBoxColumn.Name = "dinDataGridViewTextBoxColumn";
            this.dinDataGridViewTextBoxColumn.Width = 70;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 70;
            // 
            // openingQuantityInKMDataGridViewTextBoxColumn
            // 
            this.openingQuantityInKMDataGridViewTextBoxColumn.DataPropertyName = "OpeningQuantityInKM";
            this.openingQuantityInKMDataGridViewTextBoxColumn.HeaderText = "OpeningQuantityInKM";
            this.openingQuantityInKMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openingQuantityInKMDataGridViewTextBoxColumn.Name = "openingQuantityInKMDataGridViewTextBoxColumn";
            this.openingQuantityInKMDataGridViewTextBoxColumn.Width = 140;
            // 
            // openingQuantityInFKMDataGridViewTextBoxColumn
            // 
            this.openingQuantityInFKMDataGridViewTextBoxColumn.DataPropertyName = "OpeningQuantityInFKM";
            this.openingQuantityInFKMDataGridViewTextBoxColumn.HeaderText = "OpeningQuantityInFKM";
            this.openingQuantityInFKMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openingQuantityInFKMDataGridViewTextBoxColumn.Name = "openingQuantityInFKMDataGridViewTextBoxColumn";
            this.openingQuantityInFKMDataGridViewTextBoxColumn.Width = 145;
            // 
            // currentQuantityInKMDataGridViewTextBoxColumn
            // 
            this.currentQuantityInKMDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantityInKM";
            this.currentQuantityInKMDataGridViewTextBoxColumn.HeaderText = "CurrentQuantityInKM";
            this.currentQuantityInKMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityInKMDataGridViewTextBoxColumn.Name = "currentQuantityInKMDataGridViewTextBoxColumn";
            this.currentQuantityInKMDataGridViewTextBoxColumn.Width = 140;
            // 
            // currentQuantityInFKMDataGridViewTextBoxColumn
            // 
            this.currentQuantityInFKMDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantityInFKM";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.HeaderText = "CurrentQuantityInFKM";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityInFKMDataGridViewTextBoxColumn.Name = "currentQuantityInFKMDataGridViewTextBoxColumn";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.Width = 140;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 80;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Visible = false;
            this.lengthDataGridViewTextBoxColumn.Width = 125;
            // 
            // isNewDataGridViewCheckBoxColumn
            // 
            this.isNewDataGridViewCheckBoxColumn.DataPropertyName = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.HeaderText = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isNewDataGridViewCheckBoxColumn.Name = "isNewDataGridViewCheckBoxColumn";
            this.isNewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isNewDataGridViewCheckBoxColumn.Visible = false;
            this.isNewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataSource = typeof(SPDM.DLL.Entities.Stock);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1115, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coil";
            // 
            // txtDrum
            // 
            this.txtDrum.Location = new System.Drawing.Point(839, 53);
            this.txtDrum.Name = "txtDrum";
            this.txtDrum.Size = new System.Drawing.Size(262, 22);
            this.txtDrum.TabIndex = 3;
            // 
            // txtCoil
            // 
            this.txtCoil.Location = new System.Drawing.Point(1171, 53);
            this.txtCoil.Name = "txtCoil";
            this.txtCoil.Size = new System.Drawing.Size(262, 22);
            this.txtCoil.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(839, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 41);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // cmoCategory
            // 
            this.cmoCategory.FormattingEnabled = true;
            this.cmoCategory.Location = new System.Drawing.Point(109, 58);
            this.cmoCategory.Name = "cmoCategory";
            this.cmoCategory.Size = new System.Drawing.Size(262, 24);
            this.cmoCategory.TabIndex = 7;
            this.cmoCategory.SelectedIndexChanged += new System.EventHandler(this.cmoCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item";
            // 
            // cmoItem
            // 
            this.cmoItem.FormattingEnabled = true;
            this.cmoItem.Location = new System.Drawing.Point(460, 56);
            this.cmoItem.Name = "cmoItem";
            this.cmoItem.Size = new System.Drawing.Size(262, 24);
            this.cmoItem.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "From Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "To Date";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1450, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.EditValue = null;
            this.dTPFromDate.Location = new System.Drawing.Point(109, 113);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(8);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dTPFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPFromDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPFromDate.Size = new System.Drawing.Size(262, 22);
            this.dTPFromDate.TabIndex = 36;
            // 
            // dTPToDate
            // 
            this.dTPToDate.EditValue = null;
            this.dTPToDate.Location = new System.Drawing.Point(460, 109);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(8);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTPToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dTPToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTPToDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dTPToDate.Size = new System.Drawing.Size(262, 22);
            this.dTPToDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1151, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(815, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(21, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 44;
            this.label13.Text = "frmStockList";
            // 
            // frmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1479, 595);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmoItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmoCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCoil);
            this.Controls.Add(this.txtDrum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvStock);
            this.Name = "frmStockList";
            this.Load += new System.EventHandler(this.frmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrum;
        private System.Windows.Forms.TextBox txtCoil;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmoCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmoItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.DateEdit dTPFromDate;
        private DevExpress.XtraEditors.DateEdit dTPToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiscalyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingQuantityInKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingQuantityInFKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQuantityInKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQuantityInFKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label13;
    }
}