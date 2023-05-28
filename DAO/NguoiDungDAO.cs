using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
  public class NguoiDungDAO
    {
      
            private static NguoiDungDAO instance;

            public static NguoiDungDAO Instance
            {
                get
                {
                    if (instance == null) { instance = new NguoiDungDAO(); }
                    return instance;
                }
                set { instance = value; }
            }

        public List<NguoiDung> getNhom1()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec GetNhom1 ");
            foreach (DataRow r in result.Rows)
            {
               NguoiDung s = new NguoiDung(r);
                list.Add(s);
            }
            return list;
        }
        public List<NguoiDung> getNhom2()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec GetNhom2 ");
            foreach (DataRow r in result.Rows)
            {
                NguoiDung s = new NguoiDung(r);
                list.Add(s);
            }
            return list;
        }
        public List<NguoiDung> getNhom3()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec GetNhom3 ");
            foreach (DataRow r in result.Rows)
            {
                NguoiDung s = new NguoiDung(r);
                list.Add(s);
            }
            return list;
        }
        public bool SuaNguoiDung(string ma, string usernam, string pass)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec SuaNguoiDung @maNguoiDung  , @user  , @pass  ", new object[] { ma, usernam, pass });
            return res > 0;
        }

        public bool AddNguoiDung1(string ma, string ten, string pass )
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec  TaoNguoiDung @maNguoiDung , @username  , @pass  , @manhom   ", new object[] { ma, ten,pass, "1" });
            return res > 0;
        }
        public bool AddNguoiDung2(string ma, string ten, string pass)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec  TaoNguoiDung @maNguoiDung , @username  , @pass  , @manhom   ", new object[] { ma, ten, pass, "2" });
            return res > 0;
        }
        public bool AddNguoiDung3(string ma, string ten, string pass)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec  TaoNguoiDung @maNguoiDung , @username  , @pass  , @manhom   ", new object[] { ma, ten, pass, "3" });
            return res > 0;
        }
        public bool XoaNguoiDung(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec XoaNguoiDung @maNguoiDung   ", new object[] { man });
            return res > 0;
        }
     
    }
}
