using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.ExternalIntercept.Models;

namespace WebApp.ExternalIntercept.Controllers
{
    public class LeavingController : Controller
    {
        // GET: Leaving
        public ActionResult Index()
        {
            return View(
                new LeavingViewModel(
                    Request.QueryString["URL"],
                    Request.UrlReferrer
                )
            );
        }
    }
}