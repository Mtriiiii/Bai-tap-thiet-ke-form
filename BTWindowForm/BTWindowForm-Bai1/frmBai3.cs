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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void rbTong2So_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tboSoA.Text);
            int b = int.Parse(tboSoB.Text);
            int n = int.Parse(tboSoN.Text);
            int kq=0;

            if(rbTong2So.Checked)
            {
                TinhToan.CongHaiSo(a, b, ref kq);
                lblKetQua.Text = kq.ToString();
            }
            else
            {
                kq = TinhToan.TongDaySo(n);
                lblKetQua.Text = kq.ToString();
            }
        }
    }
}
