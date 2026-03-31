using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class PhanCongNhanVien
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public string CaLam { get; set; }
        public String NgayLam { get; set; }
    }
}
