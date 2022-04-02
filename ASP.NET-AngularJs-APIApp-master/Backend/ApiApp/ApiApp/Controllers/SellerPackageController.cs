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
    public class SellerPackageController : ApiController
    {
        [Route("api/Package/GetAll/{id}")]
        [HttpGet]
        public List<PackageModel> GetAllPackages(int id)
        {
            return SellerPackageService.GetAllPackages(id);
        }

        [Route("api/Package/Add/{id}")]
        [HttpPost]
        public void Add(int id, PackageModel p)
        {
            SellerPackageService.AddProduct(id, p);
        }

        [Route("api/Package/edit/{id}")]
        [HttpGet]
        public List<PackageModel> GetPackage(int id)
        {
            return SellerPackageService.GetPackage(id);
        }
        [Route("api/Package/edit/{id}")]
        [HttpPost]
        public void Edit(int id, PackageModel p)
        {
            SellerPackageService.EditPackage(id, p);
        }
        [Route("api/Package/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            SellerPackageService.DeletePackage(id);
        }

        [Route("api/Package/Search/{search}/{id}")]
        [HttpGet]
        public List<PackageModel> GetSearchPackage(string search, int id)
        {
            return SellerPackageService.GetSearchPackage(search, id);
        }
    }
}
