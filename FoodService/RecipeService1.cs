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
		public Recipe getRecipes(int id)
		{
			masterEntities m = new masterEntities();
			var Recipelst = from k in m.Recipe where k.Recipe_id == id select k;
			var recipe = new Recipe();
			foreach (var rcp in Recipelst)
			{
				recipe = rcp;
			}
			return recipe;
		}

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

		public String findRecipesByName(String recipe_name)
		{
			masterEntities m = new masterEntities();
			List<Recipe> recipes = new List<Recipe>();
			var Recipelst = from k in m.Recipe where k.Recipe_name == recipe_name select k;
			foreach (Recipe recipe in Recipelst)
			{
				recipes.Add(recipe);
			}
			return new JavaScriptSerializer().Serialize(recipes);
		}

        public String findRecipesById(int recipe_id)
        {
            masterEntities m = new masterEntities();
            var RecipeDtb = from k in m.Recipe where k.Recipe_id == recipe_id select k;

            foreach (Recipe rcp in RecipeDtb)
            {
                return new JavaScriptSerializer().Serialize(rcp);
            }

            return null;
        }

        public String getAllRecipes()
		{
			masterEntities m = new masterEntities();
			List<Recipe> recipes = new List<Recipe>();
			var recipelist = from k in m.Recipe select k;
			foreach (Recipe recipe in recipelist)
			{
				recipes.Add(recipe);
			}
			return new JavaScriptSerializer().Serialize(recipes);

		}

	}
}