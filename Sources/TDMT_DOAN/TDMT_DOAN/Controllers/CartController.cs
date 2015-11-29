using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDMT_DOAN.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult CartContent()
        {
            return View();

        }

    }
}