using ClientSide.Models;
using ClientSide.UserServiceReference;
using FoodService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
				return View("Profile", GetUserByCookie());
			}
			return View();
		}

		public ActionResult Profile()
		{
			return View();
		}

		public ActionResult UpdateProfile()
		{
			users user = GetUserByCookie();
			return View("UpdateProfile", user);
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

		public ActionResult PushUpdate(users user)
		{
			userServiceClient.updateUser(user);
			return View("Profile", user);

		}

		[HttpPost]
		public ActionResult Create(SignUpModel s)
		{
			userServiceClient.AddUser(s.First_name, s.Last_name, s.userName, s.password, s.weight, s.height, s.vegetarian, s.vegan, s.dairyfree, s.glutenfree, s.gender);
			return RedirectToAction("Profile", "Home");
		}


		public ActionResult SignUp()
		{
			return View();
		}

		[HttpGet]
		public users GetUserByCookie()
		{
			int value = -1;
			if (Request.Cookies["userid"] != null)
			{
				value = int.Parse(Request.Cookies["userid"].Value);
			}
			return new JavaScriptSerializer().Deserialize<users>(userServiceClient.GetUser(value));
		}
	}
}
		