using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static ApiAppEntities db;
        static DataAccessFactory()
        {
            db = new ApiAppEntities();
        }

        public static IRepository<User, int, string> UserDataAcess()
        {
            return new UserRepo(db);
        }

        public static IReposNotice<Notice, int, string> NoticeDataAcess()
        {
            return new NoticeRepo(db);
        }

        public static IReposRating<Rating, int> RatingDataAcess()
        {
            return new RatingRepo(db);
        }

        public static IReposVoucher<Voucher, int, string> VoucherDataAcess()
        {
            return new VoucherRepo(db);
        }
        public static IReposAuditLog<Auditlog> AuditLogDataAcess()
        {
            return new AuditLogRepo(db);
        }


        public static IRepo<Package, int, string> SellerPackageDataAcess()
        {
            return new SellerPackageRepo(db);
        }

        public static IRepos<Order, int, string> SellerOrderDataAcess()
        {
            return new SellerOrderRepo(db);
        }
        public static IRepos<User, int> SellerProfileDataAcess()
        {
            return new SellerProfileRepo(db);
        }

        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo(db);
        }

    }
}