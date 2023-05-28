using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOAAn
{
    public class PhanCong
    { private string id;
        private string ten;
        private string mamon;
        private string? email;
        private string? sdt;
        private string malop;
        private string monhoc;
        public PhanCong(DataRow row)
        {
            this.Id = row["MaGiangVien"].ToString();
            this.Ten = row["HoTen"].ToString();
            this.MaMonHoc= row["MaMonHoc"].ToString();

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
            this.Malop = row["MaLop"].ToString();
            this.Monhoc = row["TenMonHoc"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string? Email { get => email; set => email = value; }
        public string? Sdt { get => sdt; set => sdt = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Monhoc { get => monhoc; set => monhoc = value; }
        public string MaMonHoc { get => mamon; set => mamon = value; }
    }
}
