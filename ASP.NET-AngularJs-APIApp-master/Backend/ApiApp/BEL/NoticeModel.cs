using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NoticeModel
    {
        public int noticeid { get; set; }
        public string usertype { get; set; }
        public string notice1 { get; set; }
        public System.DateTime createdat { get; set; }
        public string status { get; set; }
        public int userid { get; set; }
        public string user_name { get; set; }

        public virtual UserModel User { get; set; }
    }
}