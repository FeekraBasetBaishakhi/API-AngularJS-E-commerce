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
     public class SellerProfileService
    {
        public static Array[] Dashboard(int id)
        {
            var dash = DataAccessFactory.SellerProfileDataAcess().Dashboard(id);
            return dash;
        }

        public static void EditUser(UserModel us, int id)
        {
            var config = new MapperConfiguration(c =>
            {
                
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(us);
            DataAccessFactory.SellerProfileDataAcess().EditUser(data,id);

        }


    }
    
}
