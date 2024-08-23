using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm_Bai2
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void bàiSố2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 bai1 = new frmBai1();
            bai1.ShowDialog();
        }

        private void tsmBai2_Click(object sender, EventArgs e)
        {
            frmBai2 tsm2 = new frmBai2();
            tsm2.ShowDialog();
        }
    }
}
