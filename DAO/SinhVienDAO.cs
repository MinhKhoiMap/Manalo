
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null) { instance = new SinhVienDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        public bool SuaSv(string mssv, string ten, string sdt, string email, string macn,string manguoidung)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec SuaSinhVien  @masv , @hoten , @sdt , @email , @maChuyenNganh , @manguoidung", new object[] {mssv,ten,sdt,email,macn,manguoidung });
            return res > 0;
        }

        public bool AddSinhVien(string mssv, string ten, string sdt, string email, string manguoidung,string macn)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("  exec ThemSinhVien @masv , @hoten  , @sdt  ,  @email , @manGuoiDung  ,  @maChuyenNganh  ", new object[] { mssv,ten,sdt,email,manguoidung,macn });
            return res > 0;
        }
        public bool XoaSv(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec XoaSinhVien  @masv   ", new object[] { man });
            return res > 0;
        }

        public List<SinhVien> GetALLSinhVIen()
        {
            List<SinhVien> list = new List<SinhVien>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec XemSinhVien");
            foreach(DataRow r in result.Rows)
            {
                SinhVien s = new SinhVien(r);
                list.Add(s);
            }
            return list;
        }

    }
}
