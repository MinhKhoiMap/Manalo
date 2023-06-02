using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class Right
    {
        private int rightNum;
        private string connect;
        private string accountID;
        public int RightNum { get => rightNum; set => rightNum = value; }
        public string Connect { get => connect; set => connect = value; }
        public string AccountID { get => accountID; set => accountID = value; }

        public Right(DataRow row)
        {
            this.RightNum = Int32.Parse(row["MaNhomNguoiDung"].ToString());
            this.connect = row["DienGiai"].ToString();
            this.AccountID = row["MaNguoiDung"].ToString();
        }
        public Right(string connect, int num, string accountID)
        {
            this.RightNum = num;
            this.connect = connect;
            this.accountID = accountID;
        }

    }
}