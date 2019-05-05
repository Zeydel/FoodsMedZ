using ClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientSide.Controllers
{
	public class LoginController : Controller
	{
		UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();
		// GET: Login
		public ActionResult Login()
		{
			if (Request.Cookies["userid"] != null)
			{
				return RedirectToAction("Profile", "Home");
			}
			return View();
		}

		[HttpPost]
		public ActionResult Login(LoginModel model)
		{
			int code = userServiceClient.verifyUser(model.Username, model.Password);
			if (code > 0)
			{
				HttpCookie usercookie = new HttpCookie("userid");
				usercookie.Value = code.ToString();
				usercookie.Expires = DateTime.Now.AddDays(5);
				Response.Cookies.Add(usercookie);
				return RedirectToAction("Index", "Home");
			}
			else if (code == -1)
			{
				ViewBag.ErrorMessage = "No user found";
			}
			else if(code == -2)
			{
				ViewBag.ErrorMessage = "Wrong password";
			}
			return View();
		}

		public ActionResult RecipeDetails()
		{
			return View();
		}
	}
}