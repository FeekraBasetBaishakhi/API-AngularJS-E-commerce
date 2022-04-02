using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellerOrderRepo:IRepos<Order, int, string>
    {

        ApiAppEntities db;
        public SellerOrderRepo(ApiAppEntities db)
        {
            this.db = db;
        }

        public void EditStatus(int id, string status)
        {
            var es = db.Orders.FirstOrDefault(e => e.orderid == id);
            es.status = status;

            db.SaveChanges();
        }

        public List<Order> GetOrder(int id)
        {
            var list = (from p in db.Orders
                        where p.sellerid == id
                        select p).ToList();
            return list;
        }

        public List<Order> GetSearchOrder(string search, int id)
        {
            var list = (from p in db.Orders
                        where p.ordername.Contains(search)
                        where p.sellerid == id
                        select p).ToList();
            return list;
        }



        public List<Order> GetAllOrders(int id)
        {
            return db.Orders.Where(e => e.customerid == id).ToList();
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetOrders(int id)
        {
            return db.Orders.FirstOrDefault(e => e.orderid == id);
        }
    }
}
