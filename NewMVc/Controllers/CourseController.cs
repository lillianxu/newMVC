using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Web.Script.Serialization;
using NewMVc.Models;


namespace NewMVc.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        SchoolEntities db = new SchoolEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllCourses()
        {
           // List<Course> allCourse = (from c in db.Courses select c new{id}).ToList();

            var allCourse = db.Courses.Select(x => new CourseV
            {
                id = x.CourseID,
                title=x.Title
            });

           // var json = new JavaScriptSerializer().Serialize(allCourse);
           // return json;
            return this.Json(allCourse, JsonRequestBehavior.AllowGet);

        }
    }
}