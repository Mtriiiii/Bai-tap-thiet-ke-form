using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm_Bai2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public int ThanhTien()
        {
            return this.DonGia * this.SoLuong;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
