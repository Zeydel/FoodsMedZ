﻿using ClientSide.Models;
using ClientSide.UserServiceReference;
using FoodService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ClientSide.Controllers
{
    /// <summary>
    /// Controller class for login, signup and other userrelated activites
    /// </summary>
    public class LoginController : Controller
    {
        UserServiceReference.UserServiceClient userServiceClient = ServiceFactory.getUserServiceClient();

        JsonSerializerSettings jsettings = SettingSingleton.GetJsonSerializerSettings();
        /// <summary>
        /// Redirects the user to Profile page if they are currently login
        /// </summary>
        /// <returns>Returns redirection to profile if user is logged in, else returns current login view</returns>
        public ActionResult Login()
        {
            if (Request.Cookies["userid"] != null)
            {
                return View("Profile", GetUserByCookie());
            }
            return View();
        }

        public ActionResult Logout()
        {
            Response.Cookies["userid"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Login");
        }

        public bool addFavorite()
        {
            if (Request.Cookies["userid"] != null)
            {
                User user = GetUserByCookie();
                int id = Int32.Parse(Request.Form["id"]);
				if (!String.IsNullOrEmpty(user.favorites))
				{
					List<int> favorites = user.favorites.Split(',').Select(int.Parse).ToList();
					favorites.Add(id);
					string joined = string.Join(",", favorites);
					user.favorites = joined;
				}
				else {
					user.favorites = Request.Form["id"];
				}

				string newUser = JsonConvert.SerializeObject(user, jsettings);
                userServiceClient.updateUser(newUser);
                return true;
            }
            return false;

        }

        public bool removeFavorite()
        {
            if (Request.Cookies["userid"] != null)
            {
                User user = GetUserByCookie();
                int id = Int32.Parse(Request.Form["id"]);
                List<int> favorites = user.favorites.Split(',').Select(int.Parse).ToList();
                if (favorites.Contains(id))
                {
                    favorites.Remove(id);
                }
                string joined = string.Join(",", favorites);
                user.favorites = joined;
                string newUser = JsonConvert.SerializeObject(user, jsettings);
                userServiceClient.updateUser(newUser);
                return true;
            }
            return false;

        }

        /// <summary>
        /// Redirects user to Profile page
        /// </summary>
        /// <returns></returns>
        public ActionResult Profile()
        {
            if (Request.Cookies["userid"] != null)
            {
                return View("Profile", GetUserByCookie());
            }
            return RedirectToAction("Login", "Login");
        }

        /// <summary>
        /// Redirects user to a page to update 
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateProfile()
        {
            User user = GetUserByCookie();
            return View("UpdateProfile", user);
        }


        /// <summary>
        /// Logs in user based on username and password. Calls method from userservice and returns rediction based on response
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            int code = userServiceClient.verifyUser(model.Username, model.Password);
            //If code is over 0, user exist, redirect to home
            if (code > 0)
            {
                HttpCookie usercookie = new HttpCookie("userid");
                usercookie.Value = code.ToString();
                usercookie.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(usercookie);
                return RedirectToAction("Index", "Home");
            } //if code == -1, user doesnt exists
            else if (code == -1)
            {
                ViewBag.ErrorMessage = "No user found";
            }//If code == -2, user exists, but password is wrong.
            else if (code == -2)
            {
                ViewBag.ErrorMessage = "Wrong password";
            }
            return View();
        }

        /// <summary>
        /// Pushes user update to userservice
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ActionResult PushUpdate(User user)
        {
            String json = JsonConvert.SerializeObject(user, jsettings);
            userServiceClient.updateUser(json);

            return View("Profile", user);

        }

        /// <summary>
        /// Redirects to recipedetail page
        /// </summary>
        /// <returns></returns>
        public ActionResult RecipeDetails()
        {
            return View();
        }

        /// <summary>
        /// Creates a user based on signup form
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(SignUpModel s)
        {
            userServiceClient.AddUser(s.First_name, s.Last_name, s.userName, s.password, s.weight, s.height, s.vegetarian, s.vegan, s.dairyfree, s.glutenfree, s.gender);
            return RedirectToAction("Login", "Login");
        }

        /// <summary>
        /// Redirects user to signup page
        /// </summary>
        /// <returns></returns>
        public ActionResult SignUp()
        {
            return View();
        }

        /// <summary>
        /// Fetches a user object from service based on cookie in browser.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public User GetUserByCookie()
        {
            int value = -1;
            if (Request.Cookies["userid"] != null)
            {
                value = int.Parse(Request.Cookies["userid"].Value);
            }
            return JsonConvert.DeserializeObject<User>(userServiceClient.GetUser(value), jsettings);
        }
    }
}
