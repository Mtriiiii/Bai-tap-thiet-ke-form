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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboSoThuNhat.Text);
            double b = double.Parse(tboSoThuHai.Text);
            double kq;
            if(rdbCong.Checked == true ) { kq = a + b; }
            else
                if (rdbTru.Checked == true) { kq = a - b; }
                else
                    if (rdbNhan.Checked == true) { kq = a * b; }
                    else { kq = a / b; }
            lbKetQua.Text = kq.ToString();
        }
    }
}
