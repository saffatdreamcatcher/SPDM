namespace SPDM.UI
{
    partial class frmSaleDetail
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
            this.btnSaledetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaledetail
            // 
            this.btnSaledetail.Location = new System.Drawing.Point(233, 102);
            this.btnSaledetail.Name = "btnSaledetail";
            this.btnSaledetail.Size = new System.Drawing.Size(194, 42);
            this.btnSaledetail.TabIndex = 0;
            this.btnSaledetail.Text = "Save Sale Detail";
            this.btnSaledetail.UseVisualStyleBackColor = true;
            this.btnSaledetail.Click += new System.EventHandler(this.btnSaledetail_Click);
            // 
            // frmSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaledetail);
            this.Name = "frmSaleDetail";
            this.Text = "frmSaleHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaledetail;
    }
}