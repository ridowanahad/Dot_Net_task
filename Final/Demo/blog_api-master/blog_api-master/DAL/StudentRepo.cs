using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo : IRepository<Student, int>
    {
        BlogsEntities db;
        public StudentRepo (BlogsEntities db)
        {
            this.db = db;
        }

        public void Add(Student e)
        {
            db.Students.Add(e);
            db.SaveChanges();

        }
        public void Edit(Student e)
        {

            var data = db.Students.FirstOrDefault(x => x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Students.FirstOrDefault(x => x.Id == id);
            db.Students.Remove(data);
            db.SaveChanges();
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Get(int id)
        {
            return db.Students.FirstOrDefault(i => i.Id == id);
        }
    }
}
