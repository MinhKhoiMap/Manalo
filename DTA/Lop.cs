using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DOAAn
{
   public class Lop
    {
        private string malop;
        private string mamon;
        private string tenmonhoc;

        public Lop(DataRow row)
        {
            this.Malop = row["MaLop"].ToString();
            this.Mamon = row["MaMonHoc"].ToString();
            this.Tenmonhoc = row["TenMonHoc"].ToString();

        }

        public string Tenmonhoc { get => tenmonhoc; set => tenmonhoc = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Mamon { get => mamon; set => mamon = value; }
    }
}
