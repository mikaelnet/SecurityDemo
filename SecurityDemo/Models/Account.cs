using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SecurityDemo.Models
{
	public class Account
	{
		public string Owner { get; set; }
		public int Balance { get; set; }
	}

	public class XxeModel
	{
		public XmlDocument Xml { get; set; }
	}
}
