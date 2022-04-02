using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SellerProfileRepo : IRepos<User, int>
    {
        ApiAppEntities db;
        public SellerProfileRepo(ApiAppEntities db)
        {
            this.db = db;
        }
        public Array[] Dashboard(int id)
        {
            Array[] dash;
            var price = (from p in db.Orders
                         where p.sellerid == id
                         where p.status == "accepted"
                         select (p.totalprice));

            if (price != null)
            {
                var sum = Convert.ToInt32(price.Sum());
                dash = new Array[sum];
                return dash;
            }
            else
            {
                var sums = 0;
                dash = new Array[sums];
                return dash;
            }
        }

        public void EditUser(User us, int id)
        {
            var eu = db.Users.FirstOrDefault(e => e.userid == id);
            eu.name = us.name;
            eu.password = us.password;
            eu.email = us.email;
            eu.phone = us.phone;
            db.SaveChanges();
        }
    }
}
