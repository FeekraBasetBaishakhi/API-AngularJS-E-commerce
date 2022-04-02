using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        //USERS
        [Route("api/users/all")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        [Route("api/users/search/{search}")]
        [HttpGet]
        public List<UserModel> GetSearchUsers(string search)
        {
            return UserService.GetSearchUsers(search);
        }

        [Route("api/users/{id}")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }

        [Route("api/users/add")]
        [HttpPost]
        public void AddUser(UserModel user)
        {
            user.usertype = "Manager";
            user.createdat = DateTime.Now;
            UserService.AddUser(user);
        }

        [Route("api/users/edit")]
        [HttpPut]
        public void EditUser(UserModel user)
        {
            UserService.EditUser(user);
        }

        [Route("api/users/delete/{id}")]
        [HttpDelete]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }
        //order
        [Route("api/orders/all")]
        [HttpGet]
        public List<OrderModel> GetAll()
        {
            return SellerOrderService.GetAll();
        }

        //notice
        [Route("api/notices/all")]
        [HttpGet]
        public List<NoticeModel> GetAllNotices()
        {
            return NoticeService.GetAllNotices();
        }

        [Route("api/notices/search/{search}")]
        [HttpGet]
        public List<NoticeModel> GetSearchNotices(string search)
        {
            return NoticeService.GetSearchNotices(search);
        }


        [Route("api/notices/{id}")]
        [HttpGet]
        public NoticeModel GetNotice(int id)
        {
            return NoticeService.GetNotice(id);
        }

        [Route("api/notices/add")]
        [HttpPost]
        public void AddNotice(NoticeModel notice)
        {
            notice.createdat = DateTime.Now;
             NoticeService.AddNotice(notice);
        }

        [Route("api/notices/edit")]
        [HttpPut]
        public void EditNotice(NoticeModel notice)
        {
             NoticeService.EditNotice(notice);
        }

        [Route("api/notices/delete/{id}")]
        [HttpDelete]
        public void DeleteNotice(int id)
        {
             NoticeService.DeleteNotice(id);
        }

        //ratings
        [Route("api/complains/all")]
        [HttpGet]
        public List<RatingModel> GetAllRatings()
        {
            return RatingService.GetAllRatings();
        }

        [Route("api/complains/{id}")]
        [HttpGet]
        public RatingModel GetRating(int id)
        {
            return RatingService.GetRating(id);
        }

        [Route("api/complains/delete/{id}")]
        [HttpDelete]
        public void DeleteRating(int id)
        {
             RatingService.DeleteRating(id);
        }

        //voucher
        [Route("api/vouchers/all")]
        [HttpGet]
        public List<VoucherModel> GetAllVouchers()
        {
            return VoucherService.GetAllVouchers();
        }


        [Route("api/vouchers/search/{search}")]
        [HttpGet]
        public List<VoucherModel> GetSearchVouchers(string search)
        {
            return VoucherService.GetSearchVouchers(search);
        }


        [Route("api/vouchers/{id}")]
        [HttpGet]
        public VoucherModel GetVoucher(int id)
        {
            return VoucherService.GetVoucher(id);
        }

        [Route("api/vouchers/add")]
        [HttpPost]
        public void AddVoucher(VoucherModel voucher)
        {
            VoucherService.AddVoucher(voucher);
        }

        [Route("api/vouchers/edit")]
        [HttpPut]
        public void EditVoucher(VoucherModel voucher)
        {
            VoucherService.EditVoucher(voucher);
        }

        [Route("api/vouchers/delete/{id}")]
        [HttpDelete]
        public void DeleteVoucher(int id)
        {
            VoucherService.DeleteVoucher(id);
        }

        //audit
        [Route("api/auditlogs/add")]
        [HttpPost]
        public void AddAuditLog(AuditLogModel auditLog)
        {
            auditLog.createdat = DateTime.Now;
            auditLog.details = "Updated";
            AuditLogService.AddAuditLog(auditLog); 
        }

        [Route("api/auditlogs/all")]
        [HttpGet]
        public List<AuditLogModel> GetAllAuditLogs()
        {
            return AuditLogService.GetAllAuditLogs();
        }
        
       
    }
}