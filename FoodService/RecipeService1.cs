﻿using FoodService.ViewModels;
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
		/// <summary>
		/// Fetches one recipe from database based on id.
		/// </summary>
		/// <param name="id">Id of the desired recipe</param>
		/// <returns>One recipe object</returns>
		public ViewRecipe getRecipe(int id)
		{
			masterEntities m = new masterEntities();
			var Recipelst = from k in m.Recipe where k.Recipe_id == id select k;
			var recipe = new ViewRecipe();
			foreach (var rcp in Recipelst)
			{
				recipe = new ViewRecipe(rcp);
			}
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
		public void addRecipe(int recipe_id, String recipe_name, int recipe_minutes, Boolean recipe_veg,
			Boolean recipe_vegan, Boolean cheap, Boolean sustainable, Boolean glutenfree, Boolean dairyfree,
			String image, String instruction, String imageTyp)
		{
			masterEntities m = new masterEntities();
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
			masterEntities m = new masterEntities();
			List<ViewRecipe> recipes = new List<ViewRecipe>();
			var Recipelst = from k in m.Recipe where k.Recipe_name == recipe_name select k;
			foreach (Recipe recipe in Recipelst)
			{
				recipes.Add(new ViewRecipe(recipe));
			}
			return new JavaScriptSerializer().Serialize(recipes);
		}

		/// <summary>
		/// Get one recipe based on recipe id.
		/// </summary>
		/// <param name="recipe_id">Id of desired recipe</param>
		/// <returns>JSON-string representing recipe</returns>
		public String findRecipesById(int recipe_id)
		{
			masterEntities m = new masterEntities();
			var RecipeDtb = from k in m.Recipe where k.Recipe_id == recipe_id select k;

			foreach (Recipe rcp in RecipeDtb)
			{
				return new JavaScriptSerializer().Serialize(new ViewRecipe(rcp));
			}

			return null;
		}

		/// <summary>
		/// Fetches all recipe from database
		/// </summary>
		/// <returns>JSON string representing a list of all recipes</returns>
		public string getAllRecipes()
		{
			masterEntities m = new masterEntities();
			List<ViewRecipe> recipes = new List<ViewRecipe>();
			var recipelist = from k in m.Recipe select k;
			foreach (Recipe recipe in recipelist)
			{
				recipes.Add(new ViewRecipe(recipe));
			}
			return new JavaScriptSerializer().Serialize(recipes);

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
			masterEntities m = new masterEntities();
			List<ViewRecipe> recipes = new List<ViewRecipe>();
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
				recipes.Add(new ViewRecipe(recipe));
			}
			return new JavaScriptSerializer().Serialize(recipes);
		}

	}

}
