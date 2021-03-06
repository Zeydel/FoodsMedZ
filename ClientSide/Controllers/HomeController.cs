﻿using ClientSide.Models;
using FoodService;
using System;
using ClientSide.UserServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using ClientSide.RecipeServiceReference;

namespace ClientSide.Controllers
{
	public class HomeController : Controller
	{
		UserServiceClient userServiceClient = ServiceFactory.getUserServiceClient();
		RecipeServiceClient recipeServiceClient = ServiceFactory.getRecipeServiceClient();
		JsonSerializerSettings jsettings = SettingSingleton.GetJsonSerializerSettings();

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

		public ActionResult Food()
		{
			return View();
		}

		public ActionResult Health()
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


		public ActionResult SearchDetails()
		{
			return View();
		}

		public ActionResult Search()
		{
			string recipe_list = recipeServiceClient.getAllRecipes();
			List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(recipe_list, jsettings);
			IEnumerable<Recipe> recupeenum = recipes.AsEnumerable();
			return View(recupeenum);
		}

		public ActionResult doSearch(string recipe_name)
		{
			string recipe_list = recipeServiceClient.findRecipesByName(recipe_name);
			List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(recipe_name, jsettings);
			IEnumerable<Recipe> recupeenum = recipes.AsEnumerable<Recipe>();
			return View("Search", recupeenum);
		}

		public ActionResult advancedSearch(SearchModel search)
		{
			string temp = recipeServiceClient.getRecipesAdvanced(search.SearchTerm, search.Vegetarian, search.Vegan, search.Cheap, search.Glutenfree, search.Dairyfree, search.maxMinutes.GetValueOrDefault());
			List<FoodService.Recipe> recipelist = JsonConvert.DeserializeObject<List<Recipe>>(temp, jsettings);
			//return View("Search", recipelist);

			UserFavRecipes test = new UserFavRecipes();
			test.recipes = recipelist;

			if (Request.Cookies["userid"] != null)
			{
				User user = GetUserByCookie();
				if (!String.IsNullOrEmpty(user.favorites))
				{

					List<int> favorites = user.favorites.Split(',').Select(int.Parse).ToList();
					test.favorites = favorites;
				}
			}
		return View("Search", test);
		}

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

