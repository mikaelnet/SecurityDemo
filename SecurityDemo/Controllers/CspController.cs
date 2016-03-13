using System;
using System.Web.Mvc;

namespace SecurityDemo.Controllers
{
	public class CspController : Controller
	{
		public ActionResult CspWhiteList()
		{
			return View();
		}

		public ActionResult CspInline()
		{
			return View();
		}

		public ActionResult CspNounce()
		{
			return View();
		}

		public ActionResult CspHash()
		{
			return View();
		}
	}
}