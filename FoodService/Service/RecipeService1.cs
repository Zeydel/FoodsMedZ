using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;

namespace FoodService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RecipeService1" in both code and config file together.
	public class RecipeService1 : IRecipeService1
	{
		JsonSerializerSettings jsettings = SettingSingleton.GetJsonSerializerSettings();
		/// <summary>
		/// Fetches one recipe from database based on id.
		/// </summary>
		/// <param name="id">Id of the desired recipe</param>
		/// <returns>One recipe object</returns>
		public Recipe getRecipe(int id)
		{
			masterEntities m = ContextSingleton.getContext();
			var Recipelst = from k in m.Recipe where k.Recipe_id == id select k;
			var recipe = new Recipe();
			foreach (var rcp in Recipelst)
			{
				recipe = rcp;
			}
			m.Entry(recipe).State = System.Data.Entity.EntityState.Detached;
			return recipe;
		}

		/// <summary>
		/// Adds one recipe to database.
		/// </summary>
		/// <param name="recipe_id"></param>
		/// <param name="recipe_name"></param>
		/// <param name="recipe_minutes"></param>
		/// <param name="recipe_veg"></param>
		/// <param name="recipe_vegan"></param>
		/// <param name="cheap"></param>
		/// <param name="sustainable"></param>
		/// <param name="glutenfree"></param>
		/// <param name="dairyfree"></param>
		/// <param name="image"></param>
		/// <param name="instruction"></param>
		/// <param name="imageTyp"></param>
        /// <param name="ingredientList"></param>
		public void addRecipe(int recipe_id, String recipe_name, int recipe_minutes, Boolean recipe_veg,
			Boolean recipe_vegan, Boolean cheap, Boolean sustainable, Boolean glutenfree, Boolean dairyfree,
			String image, String instruction, String imageTyp, List<Ingredients> ingredientList)
		{
			masterEntities m = ContextSingleton.getContext();
			Recipe rcp = new Recipe();
			rcp.Recipe_id = recipe_id;
			rcp.Recipe_name = recipe_name;
			rcp.Recipe_minutes = recipe_minutes;
			rcp.Recipe_veg = recipe_veg;
			rcp.Recipe_vegan = recipe_vegan;
			rcp.cheap = cheap;
			rcp.sustainable = sustainable;
			rcp.glutenfree = glutenfree;
			rcp.dairyfree = dairyfree;
			rcp.image = image;
			rcp.Instructions = instruction;
			rcp.imageTyp = imageTyp;
            rcp.Ingredients = ingredientList;
			m.Recipe.Add(rcp);
			m.SaveChanges();
		}

		/// <summary>
		/// Get one recipe based on recipe name.
		/// </summary>
		/// <param name="recipe_name">Name of desired recipe</param>
		/// <returns>JSON-string representing recipe</returns>
		public String findRecipesByName(String recipe_name)
		{
			masterEntities m = ContextSingleton.getContext();
			List<Recipe> recipes = new List<Recipe>();
			var Recipelst = from k in m.Recipe where k.Recipe_name == recipe_name select k;
			foreach (Recipe recipe in Recipelst)
			{
				recipes.Add(recipe);
			}
			return JsonConvert.SerializeObject(recipes, jsettings);
		}

		/// <summary>
		/// Get one recipe based on recipe id.
		/// </summary>
		/// <param name="recipe_id">Id of desired recipe</param>
		/// <returns>JSON-string representing recipe</returns>
		public String findRecipesById(int recipe_id)
		{
			masterEntities m = ContextSingleton.getContext();
			var RecipeDtb = from k in m.Recipe where k.Recipe_id == recipe_id select k;

			foreach (Recipe rcp in RecipeDtb)
			{
				return JsonConvert.SerializeObject(rcp, jsettings);
			}

			return null;
		}

		/// <summary>
		/// Fetches all recipe from database
		/// </summary>
		/// <returns>JSON string representing a list of all recipes</returns>
		public string getAllRecipes()
		{
			masterEntities m = ContextSingleton.getContext();
			List<Recipe> recipes = new List<Recipe>();
			var recipelist = from k in m.Recipe select k;
			foreach (Recipe recipe in recipelist)
			{
				recipes.Add(recipe);
			}
			return JsonConvert.SerializeObject(recipes, jsettings);

		}

		/// <summary>
		/// Uses a super complex alorithm to perform an advanced search Query in the remote databases
		/// </summary>
		/// <param name="searchTerm"></param>
		/// <param name="vegetarian"></param>
		/// <param name="vegan"></param>
		/// <param name="cheap"></param>
		/// <param name="glutenfree"></param>
		/// <param name="dairyfree"></param>
		/// <param name="maxminues"></param>
		/// <returns>Returns a list of all the recipes matching all the terms</returns>
		public string getRecipesAdvanced(string searchTerm, bool vegetarian, bool vegan, bool cheap, bool glutenfree, bool dairyfree, int maxminues)
		{
			masterEntities m = ContextSingleton.getContext();
			List<Recipe> recipes = new List<Recipe>();
			var recipelist = from k in m.Recipe select k;
			foreach (Recipe recipe in recipelist)
			{
				if (!recipe.Recipe_name.ToLower().Contains(searchTerm.ToLower()))
				{
					continue;
				}
				if (vegetarian == true && recipe.Recipe_veg == false)
				{
					continue;
				}
				if (vegan == true && recipe.Recipe_vegan == false)
				{
					continue;
				}
				if (cheap == true && recipe.cheap == false)
				{
					continue;
				}
				if (glutenfree == true && recipe.glutenfree == false)
				{
					continue;
				}
				if (dairyfree == true && recipe.dairyfree == false)
				{
					continue;
				}
				if (maxminues < recipe.Recipe_minutes && maxminues != 0)
				{
					continue;
				}
				recipes.Add(recipe);
			}
			return JsonConvert.SerializeObject(recipes, jsettings);
		}

	}

}
