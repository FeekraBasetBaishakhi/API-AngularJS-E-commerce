using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SellerOrderController : ApiController
    {
        [Route("api/Order/GetAll/{id}")]
        [HttpGet]
        public List<OrderModel> GetAllOrders(int id)
        {
            return SellerOrderService.GetOrderList(id);
        }

        [Route("api/Order/Search/{search}/{id}")]
        [HttpGet]
        public List<OrderModel> GetSearchOrder(string search, int id)
        {
            return SellerOrderService.GetSearchOrder(search, id);
        }

        [Route("api/Order/Status/{id}/{status}")]
        [HttpGet]
        public void Edit(int id, string status)
        {
            SellerOrderService.EditStatus(id, status);
        }
    }
}
