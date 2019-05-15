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
            return View(recupeenum);
        }

        public ActionResult RecipeDetails(int id)
        {
            Recipe recipe = getRecipe(id);
            return View("RecipeDetails", recipe);
            
            
        }

        public ActionResult Favorites()
        {
            return View();
        }

        [HttpGet]
        public Recipe getRecipe(int id)
        {
			return JsonConvert.DeserializeObject<Recipe>(recipeServiceClient.findRecipesById(id));
        }
    }
}