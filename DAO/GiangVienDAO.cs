
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class GiangVienDAO
    {
        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get
            {
                if (instance == null) { instance = new GiangVienDAO(); }
                return instance;
            }
            set { instance = value; }
        }

        public bool SuaGv(string man, string ten, string sdt, string email, string manguoidung)
        {
            int res = DataProvider.Instance.ExecuteNonQuery(
                "exec ChinhsuaGiangVien @ma , @ten  ,  @sdt , @email  , @mangdung  ",
                new object[] { man, ten, sdt, email, manguoidung });
            return res > 0;
        }

        public bool AddGv(string ma, string ten, string sdt, string email, string manguoidung)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec ThemGiangVien @ma , @ten , @sdt  ,  @email , @maNguoiDUng   ", new object[] { ma, ten, sdt, email, manguoidung });
            return res > 0;
        }
        public bool XoaGv(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery(
                "exec XoasuaGiangVien  @ma   ",
                new object[] { man });
            return res > 0;
        }


        public List<GiangVien> GetALLGiangVien()
        {
            List<GiangVien> list = new List<GiangVien>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec XemGIangVienALL");
            foreach (DataRow r in result.Rows)
            {
                GiangVien s = new GiangVien(r);
                list.Add(s);
            }
            return list;
        }

        public List<GiangVien> GetGiangVien(string mangd)
        {
            List<GiangVien> list = new List<GiangVien>();
            DataTable result = DataProvider.Instance.ExecuteQuery($"exec xemTTGV @mangd = {mangd}");
            foreach (DataRow r in result.Rows)
            {
                GiangVien s = new GiangVien(r);
                list.Add(s);
            }
            return list;
        }
    }
}
