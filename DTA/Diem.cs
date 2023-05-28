using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class Diem
    {
        private string mss;
        private string id;
        private string tenhs;
        private string mamonhoc;
        private string monhoc;
        private double? diemso;

        private Diem() { }

        public Diem(DataRow row)
        {
            this.MSSV = row["MaSinhVien"].ToString();
            this.id = row["MaChiTiet"].ToString();
            this.tenhs =  row["HoTen"].ToString();
            this.Mamonhoc = row["MaMonHoc"].ToString();
            this.monhoc = row["TenMonHoc"].ToString();
            if (row["Diem"] == DBNull.Value) { this.diemso = null; }
            else
            {
                this.diemso = (double)row["Diem"];
            }
        }

        public string Tenhs { get => tenhs; set => tenhs = value; }
        public string Monhoc { get => monhoc; set => monhoc = value; }
        public double? DiemSo { get => diemso; set => diemso = value; }
        public string Id { get => id; set => id = value; }
        public string MSSV { get => mss; set => mss = value; }
        public string Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
    }
}
