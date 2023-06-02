using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class ThongTinCaNhan
    {
        private string masv;
        private string hoten;
        private string sdt;
        private string email;
        private string tenchuyennganh;

        public ThongTinCaNhan(DataRow row)
        {
            this.masv = row["MaSinhVien"].ToString();
            this.hoten = row["HoTen"].ToString();
            this.sdt = row["SoDienThoai"].ToString();
            this.email = row["Email"].ToString();
            this.tenchuyennganh = row["TenChuyenNganh"].ToString();
        }

        public string Tenchuyennganh { get => tenchuyennganh; set => tenchuyennganh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Masv { get => masv; set => masv = value; }
    }
}
