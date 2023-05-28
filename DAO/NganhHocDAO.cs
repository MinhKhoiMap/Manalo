using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class NganhHocDAO
    {
        private static NganhHocDAO instance;

        public static NganhHocDAO Instance
        {
            get
            {
                if (instance == null) { instance = new NganhHocDAO(); }
                return instance;
            }
            set { instance = value; }
        }

        public bool SuaNganh(string man, string ten)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec SuaNganh  @maNganh , @tenNganh  ", new object[] { man, ten });
            return res > 0;
        }

        public bool AddNganh(string man, string ten)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec ThemNganh  @maNganh , @tenNganh  ", new object[] { man, ten });
            return res > 0;
        }
        public bool XoaNganh(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec XoaNganh  @maNganh   ", new object[] { man });
            return res > 0;
        }

        public List<NganhHoc> GetALLNganh()
        {
            List<NganhHoc> list = new List<NganhHoc>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec  XemNganh");
            foreach (DataRow r in result.Rows)
            {
                NganhHoc s = new NganhHoc(r);
                list.Add(s);
            }
            return list;
        }
    }
}
