using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class NguoiDung
    {

        private string id;
        private string username;
        private string pass;

      

        public string Id { get => id; set => id = value; }

        public string Pass { get => pass; set => pass = value; }
        public string Username { get => username; set => username = value; }

        private NguoiDung() { }

        public NguoiDung(DataRow row)
        {
            this.Id = row["MaNguoiDung"].ToString();
            this.Username = row["UserName"].ToString();
            this.Pass = row["PassWord"].ToString();
       

        }
    }
}
