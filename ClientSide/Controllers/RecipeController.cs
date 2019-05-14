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
    public class RecipeController : Controller
    {
        RecipeServiceReference.RecipeService1Client recipeServiceClient = new RecipeServiceReference.RecipeService1Client();
        // GET: Recipe
        public ActionResult Recipes()
        {
            return View();
        }

        public ActionResult RecipeDetails(int id)
        {
            Recipe recipe = getRecipe(id);
            return View("RecipeDetails", recipe);
        }

        [HttpGet]
        public Recipe getRecipe(int id)
        {
            return new JavaScriptSerializer().Deserialize<Recipe>(recipeServiceClient.findRecipesById(id));
        }
    }
}