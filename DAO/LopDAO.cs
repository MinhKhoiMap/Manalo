using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class LopDAO
    {
        private static LopDAO instance;

        public static LopDAO Instance
        {
            get
            {
                if (instance == null) { instance = new LopDAO(); }
                return instance;
            }
            set { instance = value; }
        }



        public bool AddLop(string msv, string malop,string machitiet)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec DangKyLop @msv  , @malop , @machitiet   ", new object[] { msv,malop,machitiet });
            return res > 0;
        }
        public List<Lop> GetLop()
        {
            List<Lop> list = new List<Lop>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec  XemLopHoc");
            foreach (DataRow r in result.Rows)
            {
                Lop s = new Lop(r);
                list.Add(s);
            }
            return list;
        }

    }
}
