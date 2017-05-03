using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewMVc.Models;
using WebGrease.Css.Extensions;

namespace NewMVc.Controllers
{
    public class HomeController : Controller
    {
        SchoolEntities db = new SchoolEntities();
        // GET: Course
        public ActionResult Index()
        {
            var courses = from c in db.Courses select new { c.CourseID,c.Title};
            String str = "";
            foreach (var x in courses)
            {
                str += "{CourseID:\"" + x.CourseID + "\",title:\"" + x.Title + "\"},";

            }
            ViewBag.xxx = str.TrimEnd(',');
            return View(courses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}