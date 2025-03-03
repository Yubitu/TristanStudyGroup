using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TristanStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudents()
        {
            //List using the student model
            List<Models.Student> students = new List<Models.Student>
            {
                //values for properties to be used in study group table
                new Models.Student { StudentNumber = "u23614286", FirstName = "Tristan", LastName = "Bosman", Email = "u23614286@tuks.co.za" },
                new Models.Student { StudentNumber = "u23541416", FirstName = "Tayla", LastName = "Walther", Email = "u23541416@tuks.co.za" },
                new Models.Student { StudentNumber = "u23543681", FirstName = "Tia", LastName = "Naidoo", Email = "u23543681@tuks.co.za" },
                new Models.Student { StudentNumber = "u24650677", FirstName = "Ashton", LastName = "Theron", Email = "u24650677@tuks.co.za" },
                new Models.Student { StudentNumber = "u24924718", FirstName = "Gundo", LastName = "Ndou", Email = "u24924718@tuks.co.za" }
            };
            //return the view
            return View(students);
        }
    }
}