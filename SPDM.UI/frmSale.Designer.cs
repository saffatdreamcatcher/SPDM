namespace SPDM.UI
{
    partial class frmSale
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
            this.btnSaveSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTotalIncVat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nupDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nupVatPercent = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChallanNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpWorkOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmoItem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtParty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalIncVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscountPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVatPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSale
            // 
            this.btnSaveSale.Location = new System.Drawing.Point(46, 585);
            this.btnSaveSale.Name = "btnSaveSale";
            this.btnSaveSale.Size = new System.Drawing.Size(147, 46);
            this.btnSaveSale.TabIndex = 0;
            this.btnSaveSale.Text = "Save Sale";
            this.btnSaveSale.UseVisualStyleBackColor = true;
            this.btnSaveSale.Click += new System.EventHandler(this.btnSaveSale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work Order No:";
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Location = new System.Drawing.Point(460, 47);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(199, 22);
            this.txtWorkOrderNo.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Party:";
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Enabled = false;
            this.txtFiscalYear.Location = new System.Drawing.Point(458, 111);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(201, 22);
            this.txtFiscalYear.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiscal Year";
            // 
            // nupTotalIncVat
            // 
            this.nupTotalIncVat.Enabled = false;
            this.nupTotalIncVat.Location = new System.Drawing.Point(817, 111);
            this.nupTotalIncVat.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nupTotalIncVat.Name = "nupTotalIncVat";
            this.nupTotalIncVat.Size = new System.Drawing.Size(199, 22);
            this.nupTotalIncVat.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Inc Vat";
            // 
            // nupDiscountPercent
            // 
            this.nupDiscountPercent.Enabled = false;
            this.nupDiscountPercent.Location = new System.Drawing.Point(1173, 112);
            this.nupDiscountPercent.Name = "nupDiscountPercent";
            this.nupDiscountPercent.Size = new System.Drawing.Size(201, 22);
            this.nupDiscountPercent.TabIndex = 21;
            this.nupDiscountPercent.ValueChanged += new System.EventHandler(this.nupDiscountPercent_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1084, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Discount %";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nupVatPercent
            // 
            this.nupVatPercent.Enabled = false;
            this.nupVatPercent.Location = new System.Drawing.Point(97, 175);
            this.nupVatPercent.Name = "nupVatPercent";
            this.nupVatPercent.Size = new System.Drawing.Size(211, 22);
            this.nupVatPercent.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vat %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Status";
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.Location = new System.Drawing.Point(94, 249);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(209, 22);
            this.txtChallanNo.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Challan No:";
            // 
            // dtpWorkOrderDate
            // 
            this.dtpWorkOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWorkOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkOrderDate.Location = new System.Drawing.Point(459, 247);
            this.dtpWorkOrderDate.Name = "dtpWorkOrderDate";
            this.dtpWorkOrderDate.Size = new System.Drawing.Size(200, 22);
            this.dtpWorkOrderDate.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sale Date";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(817, 247);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Delivery Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1188, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1055, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Delivery Address:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(94, 308);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(205, 22);
            this.txtNote.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Note:";
            // 
            // cmoItem
            // 
            this.cmoItem.FormattingEnabled = true;
            this.cmoItem.Location = new System.Drawing.Point(94, 370);
            this.cmoItem.Name = "cmoItem";
            this.cmoItem.Size = new System.Drawing.Size(205, 24);
            this.cmoItem.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Item";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(459, 370);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(205, 22);
            this.txtLength.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Length";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(811, 369);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(205, 22);
            this.txtUnit.TabIndex = 42;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(751, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Unit";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(1188, 365);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(186, 22);
            this.txtUnitPrice.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1105, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Unit Price";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 424);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(201, 22);
            this.numericUpDown1.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Discount %";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(458, 425);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown2.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 427);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "Vat %";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(817, 427);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown3.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(700, 429);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 49;
            this.label19.Text = "Total Inc Vat";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(458, 181);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(201, 22);
            this.txtStatus.TabIndex = 51;
            // 
            // txtParty
            // 
            this.txtParty.Location = new System.Drawing.Point(98, 114);
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(210, 22);
            this.txtParty.TabIndex = 52;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1478, 674);
            this.Controls.Add(this.txtParty);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmoItem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpWorkOrderDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChallanNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nupVatPercent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nupDiscountPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nupTotalIncVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFiscalYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtWorkOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSale);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalIncVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscountPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVatPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkOrderNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiscalYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTotalIncVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupDiscountPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupVatPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChallanNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpWorkOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmoItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtParty;
    }
}