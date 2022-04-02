using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NoticeRepo : IReposNotice<Notice, int, string>
    {
        ApiAppEntities db;
        public NoticeRepo(ApiAppEntities db)
        {
            this.db = db;
        }

        public void AddNotice(Notice n)
        {
            db.Notices.Add(n);
            db.SaveChanges();

        }

        public void DeleteNotice(int id)
        {
            var notice = db.Notices.FirstOrDefault(e => e.noticeid == id);
            db.Notices.Remove(notice);
            db.SaveChanges();

        }

        public void EditNotice(Notice n)
        {
            var notice = db.Notices.FirstOrDefault(e => e.noticeid == n.noticeid);
            db.Entry(notice).CurrentValues.SetValues(n);
            db.SaveChanges();

        }

        public List<Notice> GetAllNotice()
        {
            return db.Notices.ToList();
        }

        public Notice GetNotice(int id)
        {
            return db.Notices.FirstOrDefault(e => e.noticeid == id);
        }

        public List<Notice> GetSearchNotice(string search)
        {
            var list = (from p in db.Notices
                        where p.notice1.Contains(search)
                        select p).ToList();
            return list;
        }
    }
}
