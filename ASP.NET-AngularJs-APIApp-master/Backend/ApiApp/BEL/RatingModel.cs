using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RatingModel
    {
        public int ratingid { get; set; }
        public int userid { get; set; }
        public int packageid { get; set; }
        public string rating1 { get; set; }
        public string complain { get; set; }
        public string complainstatus { get; set; }
        public string package_packagename { get; set; }
        public string user_name { get; set; }

        public virtual PackageModel Package { get; set; }
        public virtual UserModel User { get; set; }
    }
}