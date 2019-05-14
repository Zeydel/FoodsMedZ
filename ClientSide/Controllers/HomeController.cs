﻿using ClientSide.Models;
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
	public class HomeController : Controller
	{
		UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();
        RecipeServiceReference.RecipeService1Client recipeServiceClient = new RecipeServiceReference.RecipeService1Client();

        public ActionResult Index()
		{
			if(Request.Cookies["userid"] == null)
			{
				return RedirectToAction("Login", "Login");
			}

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

        public ActionResult RecipeTest()
        {
            return View();
        }

		public ActionResult Search()
		{
			string recipe_list = recipeServiceClient.getAllRecipes();
			List<Recipe> recipes = new JavaScriptSerializer().Deserialize<List<Recipe>>(recipe_list);
			IEnumerable<Recipe> recupeenum = recipes.AsEnumerable();
			return View(recupeenum);
		}

		public ActionResult doSearch(string recipe_name)
		{
			string recipe_list = recipeServiceClient.findRecipesByName(recipe_name);
			List<Recipe> recipes = new JavaScriptSerializer().Deserialize<List<Recipe>>(recipe_list);
			IEnumerable<Recipe> recupeenum = recipes.AsEnumerable<Recipe>();
			return View("Search", recupeenum);
		}

	}

}

