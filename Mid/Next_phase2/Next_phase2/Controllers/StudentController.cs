using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Next_phase2.Models; 

namespace Next_phase2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student s1 = new Student()
            {
                Name = "Muhammad Ridowan",
                Id = "18-37919-2",
                Dob = "13.7.1998"
            };
           /* ViewBag.Name = "Muhammad Ridowan Ahad";
            string[] names = new string[3];
            names[0] = "Ridowan";
            names[1] = "Rayhan";
            names[2] = "Innaya";

            ViewBag.Names = names;*/

            return View(s1);
        }
        public ActionResult List()
        {  
            List<Student> students = new List<Student>();
            for(int i = 0; i < 10; i++)
            {
                Student s1 = new Student()
                {
                    Name = "Muhammad Ridowan" + (i+1),
                    Id = "18-37919-2",
                    Dob = "13.7.1998"
                };
                students.Add(s1);

            }
            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateSubmit(Student s)
        {
            //Student s = new Student();
            //var c = Request;
            //from HttpRequestBase Request
            /*s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.Dob = Request["Dob"];*/

            //form FormCollection Object;
            ////  "FormCollection form" aita upore action a thakbe.
            /*s.Name = form["Name"];
            s.Id = form["Id"];
            s.Dob = form["Dob"];*/

            //from direct variables
           /* s.Name = Name;
            s.Id = Id;
            s.Dob = Dob;
*/

            return View(s);
        }
    }
}