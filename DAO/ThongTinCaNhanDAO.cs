using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn.DAO
{
   public class ThongTinCaNhanDAO
    {
        private static ThongTinCaNhanDAO instance;

        public static ThongTinCaNhanDAO Instance
        {
            get
            {
                if (instance == null) { instance = new ThongTinCaNhanDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        public List<ThongTinCaNhan> getTHonTin(string msv)
        {
            List<ThongTinCaNhan> list = new List<ThongTinCaNhan>();
            DataTable result = DataProvider.Instance.ExecuteQuery(" exec XemThongTinCaNhan @msv", new object[] { msv });
            foreach (DataRow r in result.Rows)
            {
                ThongTinCaNhan s = new ThongTinCaNhan(r);
                list.Add(s);
            }
            return list;
        }
      
    }
}
