using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class ChuyenNganhDAO
    {
        private static ChuyenNganhDAO instance;

        public static ChuyenNganhDAO Instance
        {
            get
            {
                if (instance == null) { instance = new ChuyenNganhDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        public bool SuaChuyenNganh(string macn,string ten,string mn)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec SuaChuyenNganh  @maChuyenNganh , @tenChuyenNganh , @MaNganh  ", new object[] { macn,ten,mn }) ;
            return res > 0;
        }

        public bool  AddChuyenNganh(string macn, string ten, string mn)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec ThemChuyenNganh  @maChuyenNganh , @tenChuyenNganh , @MaNganh  ", new object[] { macn, ten, mn });
            return res > 0;
        }
        public bool XoaChuyenNganh(string macn)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec XoaChuyenNganh  @maChuyenNganh  ", new object[] { macn });
            return res > 0;
        }

        public List<ChuyenNganhHoc> GetALLNganh()
        {
            List<ChuyenNganhHoc> list = new List<ChuyenNganhHoc>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec  XemChuyenNganh");
            foreach (DataRow r in result.Rows)
            {
                ChuyenNganhHoc s = new ChuyenNganhHoc(r);
                list.Add(s);
            }
            return list;
        }
    }
}
