namespace BTWindowForm
{
    partial class frmBai1
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(102, 94);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(100, 13);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Thông tin hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongBao);
            this.Name = "frmBai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label1;
    }
}