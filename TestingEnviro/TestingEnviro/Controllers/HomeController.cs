using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingEnviro.Models;

namespace TestingEnviro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calender()
        {
            return View();
        }

        public ActionResult Cancel()
        {
            return View();
        }

        public ActionResult Notify()
        {
            return View();
        }

        public ActionResult Return()
        {
            return View();
        }

        public ActionResult getAll()
        {
            List<SchedulerEvent> events = new List<SchedulerEvent>()
            {
                new SchedulerEvent()
                {
                    Id = 1,
                    Text = "Event 1",
                    StartDate = new DateTime(2019, 1, 15, 2, 0, 0),
                    EndDate = new DateTime(2019, 1, 15, 4, 0, 0)
                },
                new SchedulerEvent()
                {
                    Id = 2,
                    Text = "Event 2",
                    StartDate = new DateTime(2019, 1, 17, 3, 0, 0),
                    EndDate = new DateTime(2019, 1, 17, 6, 0, 0)
                },
                new SchedulerEvent()
                {
                    Id = 3,
                    Text = "Multiday event",
                    StartDate = new DateTime(2019, 1, 15, 0, 0, 0),
                    EndDate = new DateTime(2019, 1, 20, 0, 0, 0)
                }
            };
            return Json(events.AsEnumerable().ToList(), JsonRequestBehavior.AllowGet);
        }

        public void List()
        {

            //1 https://youtu.be/cgW-CsePoxI
            //2 https://www.youtube.com/watch?v=IKU5omv8X3s&feature=youtu.be
            //Use this link for it

            
        }
    }
}