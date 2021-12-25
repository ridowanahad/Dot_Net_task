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
  public class CourseService
    {
        public static List<CourseModel> GetAllCourses()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseModel>());
            var mapper = config.CreateMapper();
            var courses = DataAccessFactory.CourseDataAccess().Get();
            var result = mapper.Map<List<Course>, List<CourseModel>>(courses);
            return result;
        }

        public static CourseModel GetCourse(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseModel>());
            var mapper = config.CreateMapper();
            var course = DataAccessFactory.CourseDataAccess().Get(id);
            var result = mapper.Map<Course, CourseModel>(course);
            return result;
        }

        public static void CreateCourse(CourseModel course)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Course, CourseModel>();
                cfg.CreateMap<CourseModel, Course>();
            });

            var data = Mapper.Map<Course>(course);
            DataAccessFactory.CourseDataAccess().Add(data);

        }
        public static void DeleteCourse(int id)
        {
            DataAccessFactory.CourseDataAccess().Delete(id);
        }
    }
}
