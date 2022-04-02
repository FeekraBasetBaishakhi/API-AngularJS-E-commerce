using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PackageModel
    {
        public int packageid { get; set; }
        public int userid { get; set; }
        public string packagename { get; set; }
        public string price { get; set; }
        public string details { get; set; }
        public string category { get; set; }
        public string discount { get; set; }
        public System.DateTime createdat { get; set; }
        public string advertisement { get; set; }
        public string location { get; set; }
        public string approvestatus { get; set; }

        public virtual UserModel User { get; set; }
    }
}