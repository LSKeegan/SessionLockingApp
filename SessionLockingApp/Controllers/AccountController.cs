using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Diagnostics;

namespace SessionLockingApp.Controllers
{

    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RedirectToAccountPage()
        {
            // Save info to session from querystring 
            Session["Name"] = Request.QueryString["Name"];
            Session["Age"] = Request.QueryString["Age"];

            return View("Login");
        }
    }
}