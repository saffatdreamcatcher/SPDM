namespace SPDM.UI
{
    partial class frmStock
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
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiscalyear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductionNo = new System.Windows.Forms.TextBox();
            this.txtPartyId = new System.Windows.Forms.TextBox();
            this.txtWorkOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWorkOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTotalexVat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupTotalIncVat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nupDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nupVatPercent = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmoItemId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDrum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCoilNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nupUnit = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nUpOQinKM = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nUpOQinFKM = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nUpCQinKM = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.nUpCQinFKM = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalexVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalIncVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscountPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVatPercent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpOQinKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpOQinFKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpCQinKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpCQinFKM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Location = new System.Drawing.Point(40, 634);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(94, 33);
            this.btnSaveStock.TabIndex = 0;
            this.btnSaveStock.Text = "Save Stock";
            this.btnSaveStock.UseVisualStyleBackColor = true;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nupVatPercent);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nupDiscountPercent);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nupTotalIncVat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nupTotalexVat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpWorkOrderDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtWorkOrderId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPartyId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFiscalyear);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProductionNo);
            this.groupBox2.Location = new System.Drawing.Point(26, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1384, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Production";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Party ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Production No";
            // 
            // txtFiscalyear
            // 
            this.txtFiscalyear.Location = new System.Drawing.Point(456, 35);
            this.txtFiscalyear.Name = "txtFiscalyear";
            this.txtFiscalyear.Size = new System.Drawing.Size(201, 22);
            this.txtFiscalyear.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fiscal Year";
            // 
            // txtProductionNo
            // 
            this.txtProductionNo.Location = new System.Drawing.Point(131, 35);
            this.txtProductionNo.Name = "txtProductionNo";
            this.txtProductionNo.Size = new System.Drawing.Size(188, 22);
            this.txtProductionNo.TabIndex = 0;
            // 
            // txtPartyId
            // 
            this.txtPartyId.Location = new System.Drawing.Point(775, 35);
            this.txtPartyId.Name = "txtPartyId";
            this.txtPartyId.Size = new System.Drawing.Size(206, 22);
            this.txtPartyId.TabIndex = 8;
            // 
            // txtWorkOrderId
            // 
            this.txtWorkOrderId.Location = new System.Drawing.Point(1151, 32);
            this.txtWorkOrderId.Name = "txtWorkOrderId";
            this.txtWorkOrderId.Size = new System.Drawing.Size(197, 22);
            this.txtWorkOrderId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Work Order No";
            // 
            // dtpWorkOrderDate
            // 
            this.dtpWorkOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWorkOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkOrderDate.Location = new System.Drawing.Point(135, 83);
            this.dtpWorkOrderDate.Name = "dtpWorkOrderDate";
            this.dtpWorkOrderDate.Size = new System.Drawing.Size(184, 22);
            this.dtpWorkOrderDate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Work Order Date";
            // 
            // nupTotalexVat
            // 
            this.nupTotalexVat.Enabled = false;
            this.nupTotalexVat.Location = new System.Drawing.Point(456, 86);
            this.nupTotalexVat.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nupTotalexVat.Name = "nupTotalexVat";
            this.nupTotalexVat.Size = new System.Drawing.Size(201, 22);
            this.nupTotalexVat.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Ex Vat";
            // 
            // nupTotalIncVat
            // 
            this.nupTotalIncVat.Enabled = false;
            this.nupTotalIncVat.Location = new System.Drawing.Point(775, 86);
            this.nupTotalIncVat.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nupTotalIncVat.Name = "nupTotalIncVat";
            this.nupTotalIncVat.Size = new System.Drawing.Size(206, 22);
            this.nupTotalIncVat.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Inc Vat";
            // 
            // nupDiscountPercent
            // 
            this.nupDiscountPercent.Location = new System.Drawing.Point(1151, 89);
            this.nupDiscountPercent.Name = "nupDiscountPercent";
            this.nupDiscountPercent.Size = new System.Drawing.Size(201, 22);
            this.nupDiscountPercent.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1047, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Discount %";
            // 
            // nupVatPercent
            // 
            this.nupVatPercent.Location = new System.Drawing.Point(131, 143);
            this.nupVatPercent.Name = "nupVatPercent";
            this.nupVatPercent.Size = new System.Drawing.Size(188, 22);
            this.nupVatPercent.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vat %";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(775, 145);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(211, 22);
            this.txtNote.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(717, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Note";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(452, 146);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(205, 22);
            this.txtStatus.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUpCQinFKM);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.nUpCQinKM);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.nUpOQinFKM);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.nUpOQinKM);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nupUnit);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDin);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCoilNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDrum);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmoItemId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(26, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1384, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmoItemId
            // 
            this.cmoItemId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoItemId.FormattingEnabled = true;
            this.cmoItemId.Location = new System.Drawing.Point(96, 43);
            this.cmoItemId.Name = "cmoItemId";
            this.cmoItemId.Size = new System.Drawing.Size(203, 24);
            this.cmoItemId.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Item";
            // 
            // txtDrum
            // 
            this.txtDrum.Location = new System.Drawing.Point(456, 46);
            this.txtDrum.Name = "txtDrum";
            this.txtDrum.Size = new System.Drawing.Size(201, 22);
            this.txtDrum.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Drum";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(SPDM.DLL.Entities.Stock);
            // 
            // txtCoilNo
            // 
            this.txtCoilNo.Location = new System.Drawing.Point(785, 49);
            this.txtCoilNo.Name = "txtCoilNo";
            this.txtCoilNo.Size = new System.Drawing.Size(201, 22);
            this.txtCoilNo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Coil No";
            // 
            // txtDin
            // 
            this.txtDin.Location = new System.Drawing.Point(1137, 52);
            this.txtDin.Name = "txtDin";
            this.txtDin.Size = new System.Drawing.Size(201, 22);
            this.txtDin.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1073, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Din";
            // 
            // nupUnit
            // 
            this.nupUnit.Location = new System.Drawing.Point(96, 94);
            this.nupUnit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupUnit.Name = "nupUnit";
            this.nupUnit.Size = new System.Drawing.Size(201, 22);
            this.nupUnit.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Unit";
            // 
            // nUpOQinKM
            // 
            this.nUpOQinKM.Location = new System.Drawing.Point(452, 96);
            this.nUpOQinKM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpOQinKM.Name = "nUpOQinKM";
            this.nUpOQinKM.Size = new System.Drawing.Size(201, 22);
            this.nUpOQinKM.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(387, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "OQInKM";
            // 
            // nUpOQinFKM
            // 
            this.nUpOQinFKM.Location = new System.Drawing.Point(785, 98);
            this.nUpOQinFKM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpOQinFKM.Name = "nUpOQinFKM";
            this.nUpOQinFKM.Size = new System.Drawing.Size(201, 22);
            this.nUpOQinFKM.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(708, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 42;
            this.label18.Text = "OQInFKM";
            // 
            // nUpCQinKM
            // 
            this.nUpCQinKM.Location = new System.Drawing.Point(1137, 104);
            this.nUpCQinKM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpCQinKM.Name = "nUpCQinKM";
            this.nUpCQinKM.Size = new System.Drawing.Size(201, 22);
            this.nUpCQinKM.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1044, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "CQInKM";
            // 
            // nUpCQinFKM
            // 
            this.nUpCQinFKM.Location = new System.Drawing.Point(96, 159);
            this.nUpCQinFKM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpCQinFKM.Name = "nUpCQinFKM";
            this.nUpCQinFKM.Size = new System.Drawing.Size(201, 22);
            this.nUpCQinFKM.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "CQInFKM";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveStock);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalexVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalIncVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscountPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVatPercent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpOQinKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpOQinFKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpCQinKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpCQinFKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWorkOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartyId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiscalyear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductionNo;
        private System.Windows.Forms.DateTimePicker dtpWorkOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTotalexVat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupTotalIncVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupDiscountPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupVatPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDrum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmoItemId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCoilNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUpOQinFKM;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nUpOQinKM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nupUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nUpCQinFKM;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nUpCQinKM;
        private System.Windows.Forms.Label label19;
    }
}