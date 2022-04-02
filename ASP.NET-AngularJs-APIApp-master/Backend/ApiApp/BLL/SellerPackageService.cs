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
    public class SellerPackageService
    {
        public static void AddProduct(int id, PackageModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageModel, Package>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Package>(p);
            DataAccessFactory.SellerPackageDataAcess().AddProduct(id,data);
        }

        public static void EditPackage(int id, PackageModel pac)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageModel, Package>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Package>(pac);
            DataAccessFactory.SellerPackageDataAcess().EditPackage(id,data);

        }

        public static void DeletePackage(int id)
        {
            DataAccessFactory.SellerPackageDataAcess().DeletePackage(id);
        }

        public static List<PackageModel> GetAllPackages(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerPackageDataAcess();
            var data = mapper.Map<List<PackageModel>>(da.GetAllPackages(id));
            return data;
        }

        public static List<PackageModel> GetPackage(int id)
        { 
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerPackageDataAcess();
            var data = mapper.Map<List<PackageModel>>(da.GetPackage(id));
            return data;
        }

        public static List<PackageModel> GetSearchPackage(string search, int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerPackageDataAcess();
            var data = mapper.Map<List<PackageModel>>(da.GetSearchPackage(search,id));
            return data;
        }

    }
}
