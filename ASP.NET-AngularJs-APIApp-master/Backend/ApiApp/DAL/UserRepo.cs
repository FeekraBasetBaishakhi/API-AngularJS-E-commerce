using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepository<User, int, string>, IAuth
    {

        ApiAppEntities db;
        public UserRepo(ApiAppEntities db)
        {
            this.db = db;
        }

        public void AddUser(User u)
        {
            
            db.Users.Add(u);
            db.SaveChanges();

        }

       

        public void DeleteUser(int id)
        {
            var user = db.Users.FirstOrDefault(e => e.userid == id);
            db.Users.Remove(user);
            db.SaveChanges();

        }

        public void EditUser(User u)
        {
            var user = db.Users.FirstOrDefault(e => e.userid == u.userid);
            db.Entry(user).CurrentValues.SetValues(u);
            db.SaveChanges();

        }

        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public List<User> GetSearchUsers(string search)
        {
            var list = (from p in db.Users
                        where p.name.Contains(search)
                        select p).ToList();
            return list;
        }

        public User GetUser(int id)
        {
            return db.Users.FirstOrDefault(e => e.userid == id);
        }

        public Token Authenticate(User user)
        {
            var u = db.Users.FirstOrDefault(en => en.email.Equals(user.email) && en.password.Equals(user.password));
            Token t = null;
            if (u != null) 
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.userid = u.userid;
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken.Equals(token) && e.ExpiredAt == null);
            return rs;
        }

        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
            if (t != null)
            {
                t.ExpiredAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}