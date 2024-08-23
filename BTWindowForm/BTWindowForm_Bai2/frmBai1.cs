using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm_Bai2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "tb001";
            tb.TenThietBi = "Chuột";
            tb.NuocSanXuat = "Việt Nam";
            tb.DonGia = 20000;
            tb.SoLuong = 2;
            lblThanhTien.Text = tb.ThanhTien().ToString();
            lblThietBi.Text = tb.HienThi();
        }
    }
}
