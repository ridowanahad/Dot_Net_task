using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab.Models;
using System.Data.SqlClient;

namespace Lab.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            string connString = @"Server=DESKTOP-FA20EVM\SQLEXPRESS;Database=Dot_net_lab;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Cgpa = (float)reader.GetDouble(reader.GetOrdinal("Cgpa"))
            };
                students.Add(s);
            }
            conn.Close();

            return View(students);
        }
        [HttpGet]      
        public ActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Create(Student s)
        {
            string connString = @"Server=DESKTOP-FA20EVM\SQLEXPRESS;Database=Dot_net_lab;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string query = String.Format("Insert into Students values('{0}','{1}','{2}',0.0)",s.Name,s.Dob,s.Gender);
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Index");

        }
    }
}