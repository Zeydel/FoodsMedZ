﻿using ClientSide.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ClientSide.Controllers
{
	public class SignUpController : Controller
	{
		UserServiceReference.UserServiceClient signUpClient = new UserServiceReference.UserServiceClient();

		public ActionResult Index()
		{
			return View();
		}



	}
}