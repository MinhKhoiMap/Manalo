
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
   public class DiemDAO
    {
        private static DiemDAO instance;

        public static DiemDAO Instance
        {
            get
            {
                if (instance == null) { instance = new DiemDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        public List<Diem> GetALLDiem()
        {
            List<Diem> list = new List<Diem>();
            DataTable result = DataProvider.Instance.ExecuteQuery("exec  XemDiemSinhVienALL");
            foreach (DataRow r in result.Rows)
            {
                Diem s = new Diem(r);
                list.Add(s);
            }
            return list;
        }

        public bool SuaDiem(string man, string ten, string mon)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec  SuaDiem @MaCT  , @Diem , @mamon   ", new object[] { man, ten , mon});
            return res > 0;
        }

        public bool  ThemDiem(string mct,string mssv,double diem,string mamon)
        {
            int res = DataProvider.Instance.ExecuteNonQuery("exec ThemDiem  @machitiet , @mssv , @diem  , @mamon  ", new object[] { mct,mssv,diem,mamon });
            return res > 0;
        }
        public bool XoaDiem(string man)
        {
            int res = DataProvider.Instance.ExecuteNonQuery(" exec XoaDiem @MaCT   ", new object[] { man });
            return res > 0;
        }

    }
}
