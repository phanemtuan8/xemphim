using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteMovie.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Movie()
        {
            return View();
        }
    }
}