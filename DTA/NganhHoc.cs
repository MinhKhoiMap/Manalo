using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn
{
    public class NganhHoc
    {
        private string id;
        private string tennganh;
       
        public NganhHoc(DataRow row)
        {
            this.Id = row["MaNganh"].ToString();
            this.Tennganh = row["TenNganh"].ToString();
            }

        public string Id { get => id; set => id = value; }
        public string Tennganh { get => tennganh; set => tennganh = value; }
    }
}
