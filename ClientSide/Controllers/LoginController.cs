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

        public ActionResult Index()
        {
            return View ();
        }

        public int VerifyUser(string username, string password )
        {
            return userServiceClient.verifyUser(username, password);
        }


    }
}
