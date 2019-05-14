using ClientSide.Models;
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

        public ActionResult RecipeTest()
        {
            return View();
        }

		public ActionResult Search()
		{
			string recipe_list = recipeServiceClient.getAllRecipes();
			List<RecipeServiceReference.Recipe> recipes = new JavaScriptSerializer().Deserialize<List<RecipeServiceReference.Recipe>>(recipe_list);
			IEnumerable<RecipeServiceReference.Recipe> recupeenum = recipes.AsEnumerable();
			return View(recupeenum);
		}
		/// <summary>
		/// Performs a serch in the database
		/// </summary>
		/// <param name="recipe_name"></param>
		/// <returns>Returns a list of all matching recipes</returns>
		public ActionResult doSearch(string recipe_name)
		{
			string recipe_list = recipeServiceClient.findRecipesByName(recipe_name);
			List<RecipeServiceReference.Recipe> recipes = new JavaScriptSerializer().Deserialize<List<RecipeServiceReference.Recipe>>(recipe_list);
			IEnumerable<RecipeServiceReference.Recipe> recupeenum = recipes.AsEnumerable<RecipeServiceReference.Recipe>();
			return View("Search", recupeenum);
		}

	}

}

