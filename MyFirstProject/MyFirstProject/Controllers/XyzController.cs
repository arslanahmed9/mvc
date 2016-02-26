using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class XyzController : Controller
    {
        // GET: /Xyz/
        public ActionResult Abc()
        {
            Course math = new Course();
            math.totalcredits = 4;
            math.coursename = "maths 101";

            Student obj = new Student();
            obj.firstname = "arslan";
            obj.lastname = "ahmed";

            Student obj1 = new Student();
            obj1.firstname = "imran";
            obj1.lastname = "karim";

            Student obj2 = new Student();
            obj2.firstname = "yaseen";
            obj2.lastname = "ahmed";

            List<Student> students = new List<Student>();
            students.Add(obj);
            students.Add(obj1);
            students.Add(obj2);

            Course_Students cs = new Course_Students();
            cs.course = math;
            cs.students = students; 

            return View(cs);
        }

        public ActionResult Index() 
        {
            return View();
        }
    }
}
