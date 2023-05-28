using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class ChuyenNganhHoc
    {
        private string id;
        private string tenchuyennganh;
        private string tennganh;
        private string manganh;

        public ChuyenNganhHoc(DataRow row)
        {
            this.Id = row["MaChuyenNganh"].ToString();
            this.Tenchuyennganh= row["TenChuyenNganh"].ToString();
            this.Tennganh = row["TenNganh"].ToString();
            this.Manganh = row["MaNganh"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Tenchuyennganh { get => tenchuyennganh; set => tenchuyennganh = value; }
        public string Tennganh { get => tennganh; set => tennganh = value; }
        public string Manganh { get => manganh; set => manganh = value; }
    }
}
