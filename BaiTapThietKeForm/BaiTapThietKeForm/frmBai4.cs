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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            int num;
            Random random = new Random();
            for (int i = 0; i <= 10; i++) 
            {
                num = random.Next(1,100);
                listBox1.Items.Add(num.ToString());
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            foreach(var item in listBox1.Items)
            {
                if (int.Parse(item.ToString()) == num)
                {
                    lbketqua.Text = "Tìm thấy";
                    break;
                }
                else
                    lbketqua.Text = "Không tìm thấy";
            }    
        }
    }
}
