using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return Json(new { aaa = "bbb", user = new User("Ming", "Gao") }, JsonRequestBehavior.AllowGet);
        }
    }
}