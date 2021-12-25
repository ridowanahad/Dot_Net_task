using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepo : IRepository<Course, int>
    {
        BlogsEntities db;
        public CourseRepo (BlogsEntities db)
        {
            this.db = db;
        }

        public void Add(Course e)
        {
            db.Courses.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Courses.FirstOrDefault(x => x.Id == id);
            db.Courses.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Course e)
        {
            var data = db.Courses.FirstOrDefault(x => x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public Course Get(int id)
        {
            return db.Courses.FirstOrDefault(i => i.Id == id);
        }
    }
}
