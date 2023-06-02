using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn.DAO
{
    /*Nếu muốn trao quyền hay tước quyền thì cứ tạo hàm ròi 
    * làm y chang trong này nhưng nhớ thay tên procedure và tên người dùng*/
    public class TraoQuyenDAO
    {
        private static TraoQuyenDAO instance;

        public static TraoQuyenDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TraoQuyenDAO();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        //Quyen Sinh Vien
        public void SinhVienXemTHongTIN(int i)
        {
            if (i == 0)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE PhanQuyen  ; REVOKE EXECUTE ON  XemThongTinCaNhan from  SinhVien;");
                MessageBox.Show("Đã cập nhật");
                /*XemThongTinCaNhan là tên proc, 
                 * SinhVien là user, này t code sẵn hết ròi, 
                 * m chỉ việc copy paste thoi, 
                 * trong trường hơp m phân quyền giáo viên bằng sql server*/
            }
            else if (i == 1)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE PhanQuyen ;  grant EXECUTE ON  XemThongTinCaNhan to SinhVien;");
                MessageBox.Show("Đã cập nhật");
            }
        }

        public void SinhVienXemLopHov(int i)
        {
            if (i == 0)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE [PhanQuyen];  REVOKE EXECUTE ON  XemLopHoc from  SinhVien;");
                MessageBox.Show("Đã cập nhật");
            }
            else if (i == 1)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE [PhanQuyen];  grant EXECUTE ON  XemLopHoc to SinhVien;");
                MessageBox.Show("Đã cập nhật");
            }

        }
        public void SinhVienDangKyLop(int i)
        {
            if (i == 0)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE [PhanQuyen];  REVOKE EXECUTE ON  DangKyLop from  SinhVien;");
                MessageBox.Show("Đã cập nhật");
            }
            else if (i == 1)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult("USE [PhanQuyen];  grant EXECUTE ON  DangKyLop to SinhVien;");
                MessageBox.Show("Đã cập nhật");
            }
        }

        //Quyen Giang Vien
        public void XemDanhSachSV(bool allow)
        {
            if (allow)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "grant EXECUTE ON  getLopSVList to GiangVien;");
            }
            else
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "REVOKE EXECUTE ON  getLopSVList from GiangVien;");
            }
            MessageBox.Show("Cập nhật thành công!");
        }
        public void XemDiemSV(bool allow)
        {
            if (allow)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "grant EXECUTE ON  getDiemSV_GV to GiangVien;");
            }
            else
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "REVOKE EXECUTE ON  getDiemSV_GV from GiangVien;");
            }
            MessageBox.Show("Cập nhật thành công!");
        }
        public void XemTTGV(bool allow)
        {
            if (allow)
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "grant EXECUTE ON  xemTTGV to GiangVien;");
            }
            else
            {
                DataProvider.Instance.ExecuteNonQueryNoResult(
                    "USE [PhanQuyen];  " +
                    "REVOKE EXECUTE ON  xemTTGV from GiangVien;");
            }
            MessageBox.Show("Cập nhật thành công!");
        }
    }
}
