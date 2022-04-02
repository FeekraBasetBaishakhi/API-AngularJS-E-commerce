using BEL;
using BLL;
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
    public class SellerProfileController : ApiController
    {
        [Route("api/User/edit/{id}")]
        [HttpPost]
        public void Edit(UserModel us, int id)
        {
            SellerProfileService.EditUser(us, id);
        }

        [Route("api/Seller/Dashboard/{id}")]
        [HttpGet]
        public static Array[] Dashboard(int id)
        {
            return SellerProfileService.Dashboard(id);
        }
    }
}
