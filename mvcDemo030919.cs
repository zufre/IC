using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcDemo030919.Models;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
namespace mvcDemo030919.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student> { };
         
        // GET: Student
        public ActionResult Index()
        {
      
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select * from Students";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentList.Add (new Student() { Id = Int32.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = Int32.Parse(reader["Age"].ToString()) });
                }
            }
            
            con.Close();
  
            return View(StudentList);
        }
        [HttpGet]
        public ActionResult Create()
        { 

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                var name = std.Name;
                var age = std.Age;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();


                cmd.CommandText = "insert into Students Values('"+name+"',"+age+")";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
          
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]

        public ActionResult Edit(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select * from Students where Id=" + id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentList.Add(new Student()
                    {
                        Id = Int32.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = Int32.Parse(reader["Age"].ToString())
                    });
                }
            }

            con.Close();


            var std = StudentList.Where(s => s.Id == id)
           .FirstOrDefault();
            return View(std);

        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {

            var id = std.Id;
            var name = std.Name;
            var Age = std.Age;

            var stu = StudentList.Where(s => s.Id == id)
       .FirstOrDefault();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "update  Students set Name='"+name+"', Age="+Age+" where id="+ id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Index");
        }


        public ActionResult Details(Student stud)
        {
            var id = stud.Id;
            var name = stud.Name;
            var Age = stud.Age;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select * from Students where Id=" + id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentList.Add(new Student()
                    {
                        Id = Int32.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = Int32.Parse(reader["Age"].ToString())
                    });
                }
            }

            con.Close();


            var std = StudentList.Where(s => s.Id == id)
           .FirstOrDefault();
            return View(std);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select * from Students where Id="+id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentList.Add(new Student()
                    {
                        Id = Int32.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = Int32.Parse(reader["Age"].ToString())
                    });
                }
            }

            con.Close();

            
            var std = StudentList.Where(s => s.Id == id)
           .FirstOrDefault();
            return View(std);
            
        }
        [HttpPost]
        public ActionResult Delete(Student std)
        {
                var id = std.Id;
                var name = std.Name;
                var Age = std.Age;

                var stu = StudentList.Where(s => s.Id == id)
           .FirstOrDefault();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=mvcDemo030919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "delete from Students where id="+id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Index");
         
        }
    }
}
