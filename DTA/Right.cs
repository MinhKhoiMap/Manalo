﻿using System;
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

        public int RightNum { get => rightNum; set => rightNum = value; }
        public string Connect { get => connect; set => connect = value; }

        private string connect;
        public Right(DataRow row)
        {
            this.RightNum = Int32.Parse(row["MaNhomNguoiDung"].ToString());
            this.connect = row["DienGiai"].ToString();
        }
        public Right(string connect, int num)
        {
            this.RightNum = num;
            this.connect = connect;


        }

    }
}