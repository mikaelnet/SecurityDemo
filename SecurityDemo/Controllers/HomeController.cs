using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemo.Controllers
{
    public class HomeController : Controller
    {
        //public static readonly HtmlString ShaScript = new HtmlString("alert('Cacheable content using sha512');");

        public ActionResult Index()
        {
            //var scriptHash = GetSha256Hash(ShaScript.ToString());
            //Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self' '"+scriptHash+"'");
            return View();
        }

        /*public static string GetSha256Hash(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            var hashString = new SHA512Managed();
            byte[] hash = hashString.ComputeHash(bytes);
            return "sha512-"+Convert.ToBase64String(hash);
        }*/

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


    }
}