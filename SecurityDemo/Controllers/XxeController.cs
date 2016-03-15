using System;
using System.IO;
using System.Web.Mvc;
using System.Xml;
using SecurityDemo.Models;

namespace SecurityDemo.Controllers
{
	public class XxeController : Controller
	{
		[ValidateInput(false)]
		public ActionResult Index(string str = @"<?xml version=""1.0"" ?>
<!DOCTYPE foo [<!ELEMENT foo ANY ><!ENTITY xxe SYSTEM 'http://www.mikael.com/'>]>
<foo>&xxe;</foo>")
		{
			var xdoc = new XmlDocument();
			xdoc.LoadXml(str);
			return View(new XxeModel(){Xml = xdoc});
		}
	}
}