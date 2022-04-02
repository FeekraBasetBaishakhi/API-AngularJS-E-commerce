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
    public class VoucherService
    {
        public static List<VoucherModel> GetAllVouchers()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Voucher, VoucherModel>();
                c.CreateMap<User, UserModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.VoucherDataAcess();
            var data = mapper.Map<List<VoucherModel>>(da.GetAllVouchers());
            return data;
        }

        public static VoucherModel GetVoucher(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Voucher, VoucherModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.VoucherDataAcess();
            var data = mapper.Map<VoucherModel>(da.GetVoucher(id));
            return data;
        }

        public static List<VoucherModel> GetSearchVouchers(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Voucher, VoucherModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.VoucherDataAcess();
            var data = mapper.Map<List<VoucherModel>>(da.GetSearchVouchers(search));
            return data;
        }
        public static void AddVoucher(VoucherModel voucher)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VoucherModel, Voucher>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Voucher>(voucher);
            DataAccessFactory.VoucherDataAcess().AddVoucher(data);
        }

        public static void EditVoucher(VoucherModel voucher)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VoucherModel, Voucher>();
               
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Voucher>(voucher);
            DataAccessFactory.VoucherDataAcess().EditVoucher(data);

        }

        public static void DeleteVoucher(int id)
        {
            DataAccessFactory.VoucherDataAcess().DeleteVoucher(id);
        }
    }
}
