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
    public class NoticeService
    {
        public static List<NoticeModel> GetAllNotices()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NoticeDataAcess();
            var data = mapper.Map<List<NoticeModel>>(da.GetAllNotice());
            return data;
        }
        public static List<NoticeModel> GetSearchNotices(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NoticeDataAcess();
            var data = mapper.Map<List<NoticeModel>>(da.GetSearchNotice(search));
            return data;
        }

        public static NoticeModel GetNotice(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NoticeDataAcess();
            var data = mapper.Map<NoticeModel>(da.GetNotice(id));
            return data;
        }

        public static void AddNotice(NoticeModel notice)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NoticeModel, Notice>();
                c.CreateMap<UserModel,User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(notice);
            DataAccessFactory.NoticeDataAcess().AddNotice(data);
        }
        public static void EditNotice(NoticeModel notice)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NoticeModel, Notice>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(notice);
            DataAccessFactory.NoticeDataAcess().EditNotice(data);

        }

        public static void DeleteNotice(int id)
        {
            DataAccessFactory.NoticeDataAcess().DeleteNotice(id);
        }
    }
}
