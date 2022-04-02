using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherRepo : IReposVoucher<Voucher, int, string>
    {
        ApiAppEntities db;
        public VoucherRepo(ApiAppEntities db)
        {
            this.db = db;
        }
        public void AddVoucher(Voucher v)
        {
            db.Vouchers.Add(v);
            db.SaveChanges();
        }

        public void DeleteVoucher(int id)
        {
            var voucher = db.Vouchers.FirstOrDefault(e => e.voucherid == id);
            db.Vouchers.Remove(voucher);
            db.SaveChanges();
        }

        public void EditVoucher(Voucher v)
        {
            var voucher = db.Vouchers.FirstOrDefault(e => e.voucherid == v.voucherid);
            db.Entry(voucher).CurrentValues.SetValues(v);
            db.SaveChanges();
        }

        public List<Voucher> GetAllVouchers()
        {
            return db.Vouchers.ToList();
        }

        public List<Voucher> GetSearchVouchers(string search)
        {
            var list = (from p in db.Vouchers
                        where p.voucher1.Contains(search)
                        select p).ToList();
            return list;
        }

        public Voucher GetVoucher(int id)
        {
            return db.Vouchers.FirstOrDefault(e => e.voucherid == id);
        }
    }
}
