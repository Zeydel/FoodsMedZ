using ClientSide.Models;
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
    public class RecipeController : Controller
    {
        RecipeServiceReference.RecipeService1Client recipeServiceClient = new RecipeServiceReference.RecipeService1Client();
        UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();


        JsonSerializerSettings jsettings = new JsonSerializerSettings()
		{
			PreserveReferencesHandling = PreserveReferencesHandling.Objects,
			Formatting = Formatting.Indented,
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore

		};
		// GET: Recipe
		public ActionResult Recipes()
        {
            string recipe_list = recipeServiceClient.getAllRecipes();
			List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(recipe_list, jsettings);
            IEnumerable<Recipe> recupeenum = recipes.AsEnumerable();
            UserFavRecipes test = new UserFavRecipes();
            test.recipes = recipes;

            if (Request.Cookies["userid"] != null)
            {
                User user = GetUserByCookie();
                List<int> favorites = user.favorites.Split(',').Select(int.Parse).ToList();
                test.favorites = favorites;
            }
            return View(test);
        }

        public ActionResult RecipeDetails(int id)
        {
            Recipe recipe = getRecipe(id);
            return View("RecipeDetails", recipe);
            
            
        }

        public ActionResult Favorites()
        {
            if (Request.Cookies["userid"] != null)
            {
                //return View("Profile", GetUserByCookie());
                User user = GetUserByCookie();
                if (!String.IsNullOrEmpty(user.favorites)) {
                    List<int> favorites = user.favorites.Split(',').Select(int.Parse).ToList();
                    List<Recipe> recipes = new List<Recipe>();
                    foreach (int recipeId in favorites)
                    {
                        recipes.Add(getRecipe(recipeId));
                    }
                    IEnumerable<Recipe> recupeenum = recipes.AsEnumerable();
                    return View(recupeenum);
                } 
            }
            return View();
        }

        [HttpGet]
        public Recipe getRecipe(int id)
        {
			return JsonConvert.DeserializeObject<Recipe>(recipeServiceClient.findRecipesById(id));
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