using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "22000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "21000";
        }

        private void rbTrang_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = "20000";
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
                this.lbTong.Text = "";
            else
            {
                int tong = int.Parse(this.textBox1.Text) * int.Parse(this.textBox2.Text);
                this.lbTong.Text = tong.ToString();
            }
            
        }
    }
}
