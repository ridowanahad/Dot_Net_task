using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Dot_net_labEntities db;
        static DataAccessFactory() {
            db = new Dot_net_labEntities();
        }
        public static IRepository<Student,int> StudentDataAcees() {
            return new StudentRepo(db);    
        }
        public static IRepository<Department,int> DepartmentDataAccess() {
            return new DepartmentRepo(db);
        }
        
    }
}
