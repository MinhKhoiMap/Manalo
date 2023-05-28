using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class GiangVien
    {
        private string id;
        private string ten;
        private string manguoidung;
        private string? email;
        private string? sdt;
        public GiangVien(DataRow row)
        {
            this.Id = row["MaGiangVien"].ToString();
            this.Ten = row["HoTen"].ToString();
            this.Manguoidung = row["MaNguoiDung"].ToString();

            if (row["Email"] == DBNull.Value) { this.Email = null; }
            else
            {
                this.Email = row["Email"].ToString();
            }

            if (row["SoDienThoai"] == DBNull.Value) { this.Sdt = null; }
            else
            {
                this.Sdt = row["SoDienThoai"].ToString();
            }

      


        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string? Email { get => email; set => email = value; }
        public string? Sdt { get => sdt; set => sdt = value; }
        public string Manguoidung { get => manguoidung; set => manguoidung = value; }
    }
}
