using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbbai1_Click(object sender, EventArgs e)
        {
            frmBai1 bai1 = new frmBai1();
            bai1.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            frmBai2 bai2 = new frmBai2();
            bai2.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBai3 bai3 = new frmBai3();
            bai3.ShowDialog();
        }
    }
}
