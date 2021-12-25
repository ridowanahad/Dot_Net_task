using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using AutoMapper;
using DAL;


namespace BLL
{
    public class StudentService
    {
        public static List<StudentModel> GetAllStudents()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>());
            var mapper = config.CreateMapper();
            var students = DataAccessFactory.StudentDataAccess().Get();

            var result = mapper.Map<List<Student>, List<StudentModel>>(students);
            return result;
        }

        public static StudentModel GetStudent(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>());
            var mapper = config.CreateMapper();
            var student = DataAccessFactory.StudentDataAccess().Get(id);
            var result = mapper.Map<Student, StudentModel>(student);
            return result;
        }

        public static void CreateStudent(StudentModel student)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Student, StudentModel>();
                cfg.CreateMap<StudentModel, Student>();
            });

            var data = Mapper.Map<Student>(student);
            DataAccessFactory.StudentDataAccess().Add(data);
        }
        
        public static void DeleteStudent(int id)
        {
            DataAccessFactory.StudentDataAccess().Delete(id);
        }
    }
}
