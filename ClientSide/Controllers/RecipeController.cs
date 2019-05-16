using ClientSide.Models;
using ClientSide.RecipeServiceReference;
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
		RecipeServiceClient recipeServiceClient = ServiceFactory.getRecipeServiceClient();
		UserServiceClient userServiceClient = ServiceFactory.getUserServiceClient();


		JsonSerializerSettings jsettings = SettingSingleton.GetJsonSerializerSettings();
		// GET: Recipe
		public ActionResult Recipes()
        {
            string recipe_list = recipeServiceClient.getAllRecipes();
			List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(recipe_list, jsettings);
            IEnumerable<Recipe> recupeenum = recipes.AsEnumerable();
            return View(recupeenum);
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

		public ActionResult RecommendedRecipes(bool? vegetarian, bool? vegan, bool? glutenfree, bool? Dairyfree)
		{
			SearchModel searchModel = new SearchModel();
			searchModel.SearchTerm = "";
			searchModel.Vegetarian = vegetarian.GetValueOrDefault();
			searchModel.Vegan = vegan.GetValueOrDefault();
			searchModel.Glutenfree = glutenfree.GetValueOrDefault();
			searchModel.Dairyfree = glutenfree.GetValueOrDefault();
			return RedirectToAction("advancedSearch","Home", searchModel);

		}
    }
}