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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrum = new System.Windows.Forms.TextBox();
            this.txtCoil = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmoCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmoItem = new System.Windows.Forms.ComboBox();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
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
            this.isNewDataGridViewCheckBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.fiscalyearDataGridViewTextBoxColumn,
            this.drumDataGridViewTextBoxColumn,
            this.coilNoDataGridViewTextBoxColumn,
            this.dinDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.openingQuantityInKMDataGridViewTextBoxColumn,
            this.openingQuantityInFKMDataGridViewTextBoxColumn,
            this.currentQuantityInKMDataGridViewTextBoxColumn,
            this.currentQuantityInFKMDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gvStock.DataSource = this.stockBindingSource;
            this.gvStock.Location = new System.Drawing.Point(12, 186);
            this.gvStock.Name = "gvStock";
            this.gvStock.RowHeadersWidth = 51;
            this.gvStock.RowTemplate.Height = 24;
            this.gvStock.Size = new System.Drawing.Size(1455, 341);
            this.gvStock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coil";
            // 
            // txtDrum
            // 
            this.txtDrum.Location = new System.Drawing.Point(688, 60);
            this.txtDrum.Name = "txtDrum";
            this.txtDrum.Size = new System.Drawing.Size(202, 22);
            this.txtDrum.TabIndex = 3;
            // 
            // txtCoil
            // 
            this.txtCoil.Location = new System.Drawing.Point(987, 59);
            this.txtCoil.Name = "txtCoil";
            this.txtCoil.Size = new System.Drawing.Size(180, 22);
            this.txtCoil.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1193, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 59);
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
            this.cmoCategory.Size = new System.Drawing.Size(198, 24);
            this.cmoCategory.TabIndex = 7;
            this.cmoCategory.SelectedIndexChanged += new System.EventHandler(this.cmoCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item";
            // 
            // cmoItem
            // 
            this.cmoItem.FormattingEnabled = true;
            this.cmoItem.Location = new System.Drawing.Point(390, 61);
            this.cmoItem.Name = "cmoItem";
            this.cmoItem.Size = new System.Drawing.Size(205, 24);
            this.cmoItem.TabIndex = 9;
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.Location = new System.Drawing.Point(109, 109);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(200, 22);
            this.dTPFromDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "From Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "To Date";
            // 
            // dTPToDate
            // 
            this.dTPToDate.Location = new System.Drawing.Point(395, 109);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(200, 22);
            this.dTPToDate.TabIndex = 12;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
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
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Width = 125;
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
            this.drumDataGridViewTextBoxColumn.Width = 80;
            // 
            // coilNoDataGridViewTextBoxColumn
            // 
            this.coilNoDataGridViewTextBoxColumn.DataPropertyName = "CoilNo";
            this.coilNoDataGridViewTextBoxColumn.HeaderText = "CoilNo";
            this.coilNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coilNoDataGridViewTextBoxColumn.Name = "coilNoDataGridViewTextBoxColumn";
            this.coilNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // dinDataGridViewTextBoxColumn
            // 
            this.dinDataGridViewTextBoxColumn.DataPropertyName = "Din";
            this.dinDataGridViewTextBoxColumn.HeaderText = "Din";
            this.dinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinDataGridViewTextBoxColumn.Name = "dinDataGridViewTextBoxColumn";
            this.dinDataGridViewTextBoxColumn.Width = 80;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 80;
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
            this.currentQuantityInKMDataGridViewTextBoxColumn.Width = 145;
            // 
            // currentQuantityInFKMDataGridViewTextBoxColumn
            // 
            this.currentQuantityInFKMDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantityInFKM";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.HeaderText = "CurrentQuantityInFKM";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityInFKMDataGridViewTextBoxColumn.Name = "currentQuantityInFKMDataGridViewTextBoxColumn";
            this.currentQuantityInFKMDataGridViewTextBoxColumn.Width = 145;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 80;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(SPDM.DLL.Entities.Stock);
            // 
            // frmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1479, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPFromDate);
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
            this.Text = "frmStockList";
            this.Load += new System.EventHandler(this.frmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStock;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrum;
        private System.Windows.Forms.TextBox txtCoil;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmoCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmoItem;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button btnClose;
    }
}