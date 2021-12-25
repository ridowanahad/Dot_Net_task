using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static BlogsEntities db;
        static DataAccessFactory()
        {
            db = new BlogsEntities();
        }
        public static IRepository<Blog, int> BlogsDataAccess() {
            return new BlogsRepo(db);
        }
        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth AuthDataAccess() {
            return new UserRepo(db);
        }

        public static IRepository<Exam, int> ExamDataAccess()
        {
            return new ExamRepo(db);
        }

        public static IRepository<Course, int> CourseDataAccess()
        {
            return new CourseRepo(db);
        }

        public static IRepository<Student, int> StudentDataAccess()
        {
            return new StudentRepo(db);
        }
    }
}
