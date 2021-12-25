using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ExamRepo:IRepository<Exam,int>
    {
        BlogsEntities db;
        public ExamRepo(BlogsEntities db) {
            this.db = db;
        }


     

        public List<Exam> Get()
        {
            return db.Exams.ToList();
        }

        public Exam Get(int id)
        {
            return db.Exams.FirstOrDefault(x => x.ExamId == id);
        }

        public  void Add(Exam e)
        {
            db.Exams.Add(e);
            db.SaveChanges();
        }

        public  void Edit(Exam e)
        {
            var data = db.Exams.FirstOrDefault(x => x.ExamId == e.ExamId);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Exams.FirstOrDefault(x => x.ExamId == id);
            db.Exams.Remove(data);
            db.SaveChanges();
        }

    }
}
