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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            frmBai1 bai1 = new frmBai1();
            bai1.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            frmBai2 bai2 = new frmBai2();
            bai2.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            frmBai3 bai3 = new frmBai3();
            bai3.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 Bai4 = new frmBai4();
            Bai4.ShowDialog();
        }

    }
}
