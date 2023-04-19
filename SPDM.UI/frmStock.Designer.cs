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
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Location = new System.Drawing.Point(354, 165);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(94, 33);
            this.btnSaveStock.TabIndex = 0;
            this.btnSaveStock.Text = "Save Stock";
            this.btnSaveStock.UseVisualStyleBackColor = true;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveStock);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveStock;
    }
}