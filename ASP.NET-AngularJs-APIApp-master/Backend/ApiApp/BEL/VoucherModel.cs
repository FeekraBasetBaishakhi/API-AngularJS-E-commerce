using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class VoucherModel
    {
        public int voucherid { get; set; }
        public string voucherstatus { get; set; }
        public string voucher1 { get; set; }
        public int userid { get; set; }
        public string user_name { get; set; }

        public virtual UserModel User { get; set; }
    }
}