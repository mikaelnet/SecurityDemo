using System;
using System.Web;
using System.Web.Mvc;
using SecurityDemo.Models;

namespace SecurityDemo.Controllers
{
	public class CsrfController : Controller
	{
		public ActionResult Index()
		{
			var userCookie = Request.Cookies.Get("username");
			if (userCookie == null)
				return RedirectToAction("LoginForm");

			var model = new Account()
			{
				Owner = userCookie.Name,
				Balance = int.Parse(Request.Cookies["balance"].Value)
			};

			return View(model);
		}

		public ActionResult LoginForm()
		{
			return View();
		}

		public ActionResult Login(string username, string password)
		{
			Response.SetCookie(new HttpCookie("username", username));
			Response.SetCookie(new HttpCookie("balance", "1000"));
			return RedirectToAction("Index");
		}

		public ActionResult Transfer(string recipient, int amount)
		{
			var userCookie = Request.Cookies.Get("username");
			if (userCookie == null)
				return RedirectToAction("LoginForm");

			var balanceCookie = Request.Cookies.Get("balance");
			if (balanceCookie == null)
				return RedirectToAction("LoginForm");

			var balance = int.Parse(balanceCookie.Value);
			balance -= amount;
			Response.SetCookie(new HttpCookie("balance", balance.ToString()));

			return RedirectToAction("Index");
		}

		[ValidateAntiForgeryToken]
		public ActionResult Transfer2(string recipient, int amount)
		{
			var userCookie = Request.Cookies.Get("username");
			if (userCookie == null)
				return RedirectToAction("LoginForm");

			var balanceCookie = Request.Cookies.Get("balance");
			if (balanceCookie == null)
				return RedirectToAction("LoginForm");

			var balance = int.Parse(balanceCookie.Value);
			balance -= amount;
			Response.SetCookie(new HttpCookie("balance", balance.ToString()));

			return RedirectToAction("Index");
		}

		public ActionResult CsrfProtected()
		{
			var userCookie = Request.Cookies.Get("username");
			if (userCookie == null)
				return RedirectToAction("LoginForm");

			return View();
		}

		public ActionResult CsrfUnprotected()
		{
			var userCookie = Request.Cookies.Get("username");
			if (userCookie == null)
				return RedirectToAction("LoginForm");

			return View();
		}

		
	}
}