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
    public class SellerOrderService
    {
        public static void EditStatus(int id, string stat)
        {
            var d = DataAccessFactory.SellerOrderDataAcess();
            d.EditStatus(id, stat);

        }

        public static List<OrderModel> GetOrderList(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerOrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetOrder(id));
            return data;
        }

        public static List<OrderModel> GetAllOrders(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerOrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetAllOrders(id));
            return data;
        }

        public static List<OrderModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerOrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetAll());
            return data;
        }

        public static List<OrderModel> GetSearchOrder(string search, int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerOrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetSearchOrder(search, id));
            return data;
        }

        public static OrderModel GetOrders(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SellerOrderDataAcess();
            var data = mapper.Map<OrderModel>(da.GetOrders(id));
            return data;
        }

    }
}
