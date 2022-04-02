using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class AuditLogRepo : IReposAuditLog<Auditlog>
    {
        ApiAppEntities db;
        public AuditLogRepo(ApiAppEntities db)
        {
            this.db = db;
        }
        public void AddAuditLog(Auditlog a)
        {
           db.Auditlogs.Add(a);
           db.SaveChanges();
        }

        public List<Auditlog> GetAllAuditLogs()
        {
            return db.Auditlogs.ToList();
        }
    }
}
