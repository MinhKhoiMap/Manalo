using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
     public class PhanCongDAO
    {
        private static PhanCongDAO instance;

        public static PhanCongDAO Instance
        {
            get
            {
                if (instance == null) { instance = new PhanCongDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        public bool SuaPhanCong(string mgv, string mamon, string malop)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec SuaPhanCong @maGv , @mamonhoc , @maLop ", new object[] { mgv,mamon,malop });
            return res > 0;
        }

        public bool AddPhanCong(string maGv,string mamon, string malop)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("  exec PhanCong @maGv , @mamonhoc , @maLop   ", new object[] { maGv,mamon,malop });
            return res > 0;
        }
        public bool XoaPhanCong(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec XoaPhanCong  @maLop   ", new object[] { man });
            return res > 0;
        }

        public List<PhanCong> GetALLPhanCong()
        {
            List<PhanCong> list = new List<PhanCong>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec XemPhanCong");
            foreach (DataRow r in result.Rows)
            {
                PhanCong s = new PhanCong(r);
                list.Add(s);
            }
            return list;
        }
    }
}
