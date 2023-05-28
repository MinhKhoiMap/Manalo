using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class SinhVien
    {
        private string id;
        private string ten;
        private string manguoidung;
 
        private string? email;
        private string? sdt;
      
        private string machuyenganh;
          private SinhVien() { }

          public SinhVien(DataRow row)
        {
            this.id = row["MaSinhVien"].ToString();
            this.ten = row["HoTen"].ToString();
            this.Manguoidung = row["MaNguoiDung"].ToString();

            if (row["Email"] == DBNull.Value) { this.email = null; }
            else
            {
                this.email = row["Email"].ToString();
            }
            
            if (row["SoDienThoai"] == DBNull.Value) { this.sdt = null; }
            else
            {
                this.sdt = row["SoDienThoai"].ToString();
            }

            this.machuyenganh = row["MaChuyenNganh"].ToString();


        }



        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string? Email { get => email; set => email = value; }
        public string? Sdt { get => sdt; set => sdt = value; }
      
        public string Machuyenganh { get => machuyenganh; set => machuyenganh = value; }
        public string Manguoidung { get => manguoidung; set => manguoidung = value; }
    }
}
