
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMT_DOAN.Models;

namespace TDMT_DOAN.Controllers
{
    public class AccountController : Controller
    {

        //
        // GET: /Account/
        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}