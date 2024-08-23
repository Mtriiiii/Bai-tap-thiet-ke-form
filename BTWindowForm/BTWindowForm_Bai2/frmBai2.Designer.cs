namespace BTWindowForm_Bai2
{
    partial class frmBai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboSoThuNhat = new System.Windows.Forms.TextBox();
            this.tboSoThuHai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCong = new System.Windows.Forms.RadioButton();
            this.rdbTru = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.rdbChia = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai:";
            // 
            // tboSoThuNhat
            // 
            this.tboSoThuNhat.Location = new System.Drawing.Point(174, 30);
            this.tboSoThuNhat.Name = "tboSoThuNhat";
            this.tboSoThuNhat.Size = new System.Drawing.Size(100, 20);
            this.tboSoThuNhat.TabIndex = 2;
            // 
            // tboSoThuHai
            // 
            this.tboSoThuHai.Location = new System.Drawing.Point(174, 59);
            this.tboSoThuHai.Name = "tboSoThuHai";
            this.tboSoThuHai.Size = new System.Drawing.Size(100, 20);
            this.tboSoThuHai.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChia);
            this.groupBox1.Controls.Add(this.rdbNhan);
            this.groupBox1.Controls.Add(this.rdbTru);
            this.groupBox1.Controls.Add(this.rdbCong);
            this.groupBox1.Location = new System.Drawing.Point(156, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdbCong
            // 
            this.rdbCong.AutoSize = true;
            this.rdbCong.Location = new System.Drawing.Point(28, 30);
            this.rdbCong.Name = "rdbCong";
            this.rdbCong.Size = new System.Drawing.Size(50, 17);
            this.rdbCong.TabIndex = 0;
            this.rdbCong.TabStop = true;
            this.rdbCong.Text = "Cộng";
            this.rdbCong.UseVisualStyleBackColor = true;
            // 
            // rdbTru
            // 
            this.rdbTru.AutoSize = true;
            this.rdbTru.Location = new System.Drawing.Point(29, 56);
            this.rdbTru.Name = "rdbTru";
            this.rdbTru.Size = new System.Drawing.Size(41, 17);
            this.rdbTru.TabIndex = 1;
            this.rdbTru.TabStop = true;
            this.rdbTru.Text = "Trừ";
            this.rdbTru.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Location = new System.Drawing.Point(28, 81);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(51, 17);
            this.rdbNhan.TabIndex = 2;
            this.rdbNhan.TabStop = true;
            this.rdbNhan.Text = "Nhân";
            this.rdbNhan.UseVisualStyleBackColor = true;
            // 
            // rdbChia
            // 
            this.rdbChia.AutoSize = true;
            this.rdbChia.Location = new System.Drawing.Point(28, 105);
            this.rdbChia.Name = "rdbChia";
            this.rdbChia.Size = new System.Drawing.Size(46, 17);
            this.rdbChia.TabIndex = 3;
            this.rdbChia.TabStop = true;
            this.rdbChia.Text = "Chia";
            this.rdbChia.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(199, 316);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnXemKetQua.TabIndex = 5;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả là";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(255, 376);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(0, 20);
            this.lbKetQua.TabIndex = 7;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboSoThuHai);
            this.Controls.Add(this.tboSoThuNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboSoThuNhat;
        private System.Windows.Forms.TextBox tboSoThuHai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.RadioButton rdbCong;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbKetQua;
    }
}