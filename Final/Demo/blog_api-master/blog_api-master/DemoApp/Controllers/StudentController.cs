using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace DemoApp.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/Student/GetAll")]
        public List<StudentModel> GetAllStudents()
        {
            return StudentService.GetAllStudents();
        }

        [HttpGet]
        [Route("api/Student/Get/{id}")]

        public StudentModel Get(int id)
        {
            return StudentService.GetStudent(id);
        }

        [HttpPost]
        [Route("api/Student/Create")]
        public void CreateStudent(StudentModel e)
        {
            StudentService.CreateStudent(e);
        }

        [HttpGet]
        [Route("api/Student/Delete/{id}")]

        public void Delete(int id)
        {
            StudentService.DeleteStudent(id);
        }

    }
}
