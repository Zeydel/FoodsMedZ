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
            return View();
        }

		[HttpPost]
		public ActionResult Login(LoginModel model)
		{
			if (userServiceClient.verifyUser(model.Username, model.Password) > 0)
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				return View("Login");
			}

		}
	}
}