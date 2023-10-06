using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPIClass2.Models;

namespace WebAPIClass2.Controllers
{
    public class DellMVCController : Controller
    {
        // GET: DellMVC
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult createemployee(Employee emp)
        {
            using (var context = new dell_trainingEntities1())
            {
                context.Employee.Add(emp);
                context.SaveChanges();
            }

            ViewBag.msg = "record created successfully";
            return View();
        }
    }
}