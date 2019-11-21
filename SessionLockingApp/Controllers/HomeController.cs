 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Diagnostics;

namespace SessionLockingApp.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Initialize session state 
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Login()
        {
            //Gather account info 
            Thread.Sleep(10000);
            string name = "Keegan";
            int age = 22;

            return RedirectToAction("RedirectToAccountPage", "Account", new {Name = name, Age = age });
        }
    }
}