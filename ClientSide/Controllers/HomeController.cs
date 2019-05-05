﻿using ClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientSide.Controllers
{
	public class HomeController : Controller
	{
		UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();

		public ActionResult Index()
		{
			if(Request.Cookies["userid"] == null)
			{
				return RedirectToAction("Login", "Login");
			}

			return View();
		}

		public ActionResult Recipes()
		{
			return View();
		}

		public ActionResult Ingredients()
		{
			return View();
		}

		public ActionResult Health()
		{
			return View();
		}

		public ActionResult Favorites()
		{
			return View();
		}

		public ActionResult Profile()
		{

			return View();
		}

		public ActionResult About()
		{
			//ViewBag.Message = "Your application description page.";
			return View();
		}

		public ActionResult Contact()
		{
			//ViewBag.Message = "Your contact page.";

			return View();
		}

	}

}

