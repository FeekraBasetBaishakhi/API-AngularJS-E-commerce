using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RatingRepo: IReposRating<Rating, int>
    {
        ApiAppEntities db;
        public RatingRepo(ApiAppEntities db)
        {
            this.db = db;
        }

        public void AddRating(Rating r)
        {

           db.Ratings.Add(r);
            db.SaveChanges();
        }

        public void DeleteRating(int id)
        {
            var rating = db.Ratings.FirstOrDefault(e => e.ratingid == id);
            db.Ratings.Remove(rating);
            db.SaveChanges();
        }

        public void EditRating(Rating r)
        {
            var rating = db.Ratings.FirstOrDefault(e => e.ratingid == r.ratingid);
            db.Entry(rating).CurrentValues.SetValues(r);
            db.SaveChanges();
        }

        public List<Rating> GetAllRatings()
        {
            return db.Ratings.Where(e => e.complain != null).ToList();
        }

        public Rating GetRating(int id)
        {
            return db.Ratings.FirstOrDefault(e => e.ratingid == id);
        }
    }
}
