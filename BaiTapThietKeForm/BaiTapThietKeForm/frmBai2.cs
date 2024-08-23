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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        tong += 100000;
                        break;
                    case "Bàn phím":
                        tong += 150000;
                        break;
                    case "Máy in":
                        tong += 2000000;
                        break;
                    case "USB Kingmax":
                        tong += 200000;
                        break;
                }
            }
            lbTongTien.Text=tong.ToString();
        }
    }
}
