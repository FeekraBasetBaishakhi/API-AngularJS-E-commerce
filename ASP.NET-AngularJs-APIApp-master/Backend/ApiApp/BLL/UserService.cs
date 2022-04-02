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
    public class UserService
    {
        public static List<UserModel> GetAllUsers()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAcess();
            var data = mapper.Map<List<UserModel>>(da.GetAllUsers());
            return data;
        }

        public static List<UserModel> GetSearchUsers(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAcess();
            var data = mapper.Map<List<UserModel>>(da.GetSearchUsers(search));
            return data;
        }

        public static UserModel GetUser(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAcess();
            var data = mapper.Map<UserModel>(da.GetUser(id));
            return data;
        }

        public static void AddUser(UserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            DataAccessFactory.UserDataAcess().AddUser(data);
        }

        public static void EditUser(UserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            DataAccessFactory.UserDataAcess().EditUser(data);

        }

        public static void DeleteUser(int id)
        {
            DataAccessFactory.UserDataAcess().DeleteUser(id);
        }

        
    }
}