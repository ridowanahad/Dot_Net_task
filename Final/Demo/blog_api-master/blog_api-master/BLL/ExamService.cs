using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
  public  class ExamService
    {
        public static List<ExamModel> GetAllExams()
        {
         

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Exam, ExamModel>());
            var mapper = config.CreateMapper();
            var exams = DataAccessFactory.ExamDataAccess().Get();
            var result = mapper.Map<List<Exam>, List<ExamModel>>(exams);
            return result;
        }

        public static ExamModel GetExam(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Exam, ExamModel>());
            var mapper = config.CreateMapper();
            var exams = DataAccessFactory.ExamDataAccess().Get(id);
            var result = mapper.Map<Exam, ExamModel>(exams);
            return result;
        }

        public static void CreateExam(ExamModel exams)
        {
            //var config = new MapperConfiguration(c => c.CreateMap<ExamModel, Exam>());
            //var mapper = new Mapper(config);
            //var result = mapper.Map<ExamModel, Exam>(exams);
            //DataAccessFactory.ExamDataAccess().Add(result);
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Exam, ExamModel>();
                cfg.CreateMap<ExamModel, Exam>();
            });

            var data = Mapper.Map<Exam>(exams); // for automapper 6.1.1
            DataAccessFactory.ExamDataAccess().Add(data);

  
        }

        public static void DeleteExam(int id)
        {
            DataAccessFactory.ExamDataAccess().Delete(id);
        }
    }
}
