namespace BTWindowForm
{
    partial class frmBai3
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
            this.label3 = new System.Windows.Forms.Label();
            this.tboSoA = new System.Windows.Forms.TextBox();
            this.tboSoB = new System.Windows.Forms.TextBox();
            this.tboSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbTong2So = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số n -";
            // 
            // tboSoA
            // 
            this.tboSoA.Location = new System.Drawing.Point(115, 44);
            this.tboSoA.Name = "tboSoA";
            this.tboSoA.Size = new System.Drawing.Size(100, 20);
            this.tboSoA.TabIndex = 3;
            // 
            // tboSoB
            // 
            this.tboSoB.Location = new System.Drawing.Point(115, 89);
            this.tboSoB.Name = "tboSoB";
            this.tboSoB.Size = new System.Drawing.Size(100, 20);
            this.tboSoB.TabIndex = 4;
            // 
            // tboSoN
            // 
            this.tboSoN.Location = new System.Drawing.Point(115, 145);
            this.tboSoN.Name = "tboSoN";
            this.tboSoN.Size = new System.Drawing.Size(100, 20);
            this.tboSoN.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbTong2So);
            this.groupBox1.Location = new System.Drawing.Point(132, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tính tổng dãy số n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbTong2So
            // 
            this.rbTong2So.AutoSize = true;
            this.rbTong2So.Location = new System.Drawing.Point(15, 30);
            this.rbTong2So.Name = "rbTong2So";
            this.rbTong2So.Size = new System.Drawing.Size(126, 17);
            this.rbTong2So.TabIndex = 0;
            this.rbTong2So.TabStop = true;
            this.rbTong2So.Text = "Tính tổng của a và b";
            this.rbTong2So.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(187, 341);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnXemKetQua.TabIndex = 7;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(375, 89);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 18);
            this.lblKetQua.TabIndex = 9;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboSoN);
            this.Controls.Add(this.tboSoB);
            this.Controls.Add(this.tboSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboSoA;
        private System.Windows.Forms.TextBox tboSoB;
        private System.Windows.Forms.TextBox tboSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbTong2So;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}