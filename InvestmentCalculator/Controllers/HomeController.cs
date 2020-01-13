using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Investment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Language)
        {
            if (Language == null || Language == "")
                Language = "en";


            if (HttpContext.Request.Cookies["Language"] == null || HttpContext.Request.Cookies["Language"].Value != Language)
                ChangeLanguage(Language);

            return View();
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

        //public ActionResult ChangeLanguage(string Language)
        //{
        //    if (Language != null && Language != "")
        //    {
        //        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
        //        Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);

        //         HttpCookie cookie = new HttpCookie("Language")
        //        {
        //            Value = Language
        //        };
        //         Response.Cookies.Add(cookie);
        //    }

        //    return View("Index");
        //}

        private void ChangeLanguage(string Language)
        {
            if (Language != null && Language != "")
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);

                HttpCookie cookie = new HttpCookie("Language")
                {
                    Value = Language
                };
                Response.Cookies.Add(cookie);
            }
        }

    }
}