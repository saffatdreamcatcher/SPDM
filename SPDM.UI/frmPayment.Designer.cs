namespace SPDM.UI
{
    partial class frmPayment
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
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.btnSavePaymentDeatil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Location = new System.Drawing.Point(295, 150);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(171, 43);
            this.btnSavePayment.TabIndex = 0;
            this.btnSavePayment.Text = "Save Payment";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // btnSavePaymentDeatil
            // 
            this.btnSavePaymentDeatil.Location = new System.Drawing.Point(223, 233);
            this.btnSavePaymentDeatil.Name = "btnSavePaymentDeatil";
            this.btnSavePaymentDeatil.Size = new System.Drawing.Size(311, 40);
            this.btnSavePaymentDeatil.TabIndex = 1;
            this.btnSavePaymentDeatil.Text = "Save Payment Detail";
            this.btnSavePaymentDeatil.UseVisualStyleBackColor = true;
            this.btnSavePaymentDeatil.Click += new System.EventHandler(this.btnSavePaymentDeatil_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSavePaymentDeatil);
            this.Controls.Add(this.btnSavePayment);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnSavePaymentDeatil;
    }
}