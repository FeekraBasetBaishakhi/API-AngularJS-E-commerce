using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int userid { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string usertype { get; set; }
        public System.DateTime createdat { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
    }
}