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
    public class RatingService
    {
        public static List<RatingModel> GetAllRatings()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Rating, RatingModel>();
                c.CreateMap<Package, PackageModel>();
                c.CreateMap<User, UserModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.RatingDataAcess();
            var data = mapper.Map<List<RatingModel>>(da.GetAllRatings());
            return data;
        }

        public static RatingModel GetRating(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Rating, RatingModel>();
                c.CreateMap<Package, PackageModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.RatingDataAcess();
            var data = mapper.Map<RatingModel>(da.GetRating(id));
            return data;

        }

        public static void AddRating(RatingModel rating)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RatingModel, Rating>();
                c.CreateMap<PackageModel, Package>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Rating>(rating);
            DataAccessFactory.RatingDataAcess().AddRating(data);
        }

        public static void EditRating(RatingModel rating)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RatingModel, Rating>();
                c.CreateMap<PackageModel, Package>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Rating>(rating);
            DataAccessFactory.RatingDataAcess().EditRating(data);

        }

        public static void DeleteRating(int id)
        {
            DataAccessFactory.RatingDataAcess().DeleteRating(id);
        }
    }
}
