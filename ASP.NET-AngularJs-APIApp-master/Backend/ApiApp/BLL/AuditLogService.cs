using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuditLogService
    {
        public static void AddAuditLog(AuditLogModel auditLog)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AuditLogModel, Auditlog>();
                c.CreateMap< ActionModel,  DAL.Action > ();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Auditlog>(auditLog);
            DataAccessFactory.AuditLogDataAcess().AddAuditLog(data);

        }
        public static List<AuditLogModel> GetAllAuditLogs()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Auditlog,AuditLogModel > ();
                c.CreateMap<DAL.Action,ActionModel>();
                c.CreateMap<User,UserModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.AuditLogDataAcess();
            var data = mapper.Map<List<AuditLogModel>>(da.GetAllAuditLogs());
            return data;
        }
    }
}
