using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SellerPackageRepo: IRepo<Package,int,string>
    {

        ApiAppEntities db;
        public SellerPackageRepo(ApiAppEntities db)
        {
            this.db = db;
        }

        public void AddProduct(int id, Package p)
        {
            p.createdat = DateTime.Now;
            p.approvestatus = "pending";
            p.userid = id;
            db.Packages.Add(p);
            db.SaveChanges();
        }

        public void DeletePackage(int id)
        {
            var pa = db.Packages.FirstOrDefault(e => e.packageid == id);
            db.Packages.Remove(pa);
            db.SaveChanges();
        }

        public void EditPackage(int id, Package p)
        {
            var ep = db.Packages.FirstOrDefault(e => e.packageid == id);
            ep.packagename = p.packagename;
            ep.price = p.price;
            ep.category = p.category;
            ep.discount = p.discount;
            ep.details = p.details;
            ep.location = p.location;
            ep.advertisement = p.advertisement;
            db.SaveChanges();
        }

        public List<Package> GetAllPackages(int id)
        {
            var list = (from p in db.Packages
                        where p.userid == id
                        select p).ToList();
            return list;
        }

        public List<Package> GetPackage(int id)
        {
            return db.Packages.Where(e => e.packageid == id).ToList();
        }

        public List<Package> GetSearchPackage(string search, int id)
        {
            var list = (from p in db.Packages
                        where p.packagename.Contains(search)
                        where p.userid == id
                        select p).ToList();
            return list;
        }
    }
}

