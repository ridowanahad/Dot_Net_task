using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL; //The models are here
using BLL; //The service (Exchange OF Model 2 Entity

namespace DemoApp.Controllers
{
    public class CourseController : ApiController
    {
        [HttpGet]
        [Route("api/Course/GetAll")]

        public List<CourseModel> GetAllCourses()
        {
            return CourseService.GetAllCourses();
        }

        [HttpGet]
        [Route("api/Course/Get/{id}")]

        public CourseModel Get(int id)
        {
            return CourseService.GetCourse(id);
        }

        [HttpPost()]
        [Route("api/Course/Create")]
        public void CreateCourse(CourseModel e)
        {
            CourseService.CreateCourse(e);
        }

        [HttpGet]
        [Route("api/Course/Delete/{id}")]
        public void Delete(int id)
        {
            CourseService.DeleteCourse(id);
        }

    }
}
