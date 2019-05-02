using ClientSide.Models;
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

		[HttpPost]
		public ActionResult Login(LoginModel model)
		{
			userServiceClient.verifyUser(model.Username, model.Password);

			return View("Index", model);
		}

		public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

		public ActionResult Login()
		{
			return View();
		}
    
		[HttpPost]
		public ActionResult SignUp(SignUpModel model)
		{ 

		userServiceClient.AddUser(model.First_name, model.Last_name, model.userName, model.password, model.weight, model.height, model.vegetarian, model.vegan, model.dairyfree, model.glutenfree, model.gender);

		return View("Index", model);

		}

		public ActionResult SignUp()
		{
			return View();
		}


}

}


