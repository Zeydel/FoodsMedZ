using FoodService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRecipeService1" in both code and config file together.
    [ServiceContract]
    public interface IRecipeService1
    {
		/// <summary>
		/// Fetches one recipe from database based on id.
		/// </summary>
		/// <param name="id">Id of the desired recipe</param>
		/// <returns>One recipe object</returns>
        [OperationContract]
        ViewRecipe getRecipe(int id);

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
        [OperationContract]
        void addRecipe(int recipe_id, String recipe_name, int recipe_minutes, Boolean recipe_veg, Boolean recipe_vegan,
            Boolean cheap, Boolean sustainable, Boolean glutenfree, Boolean dairyfree, String image, String instruction,
            String imageTyp);

		/// <summary>
		/// Get one recipe based on recipe name.
		/// </summary>
		/// <param name="recipe_name">Name of desired recipe</param>
		/// <returns>JSON-string representing recipe</returns>
		[OperationContract]
		String findRecipesByName(String recipe_name);

		[OperationContract]
		String findRecipesById(int recipe_id);

		/// <summary>
		/// Fetches all recipe from database
		/// </summary>
		/// <returns>JSON string representing a list of all recipes</returns>
		[OperationContract]
		String getAllRecipes();

		[OperationContract]
		string getRecipesAdvanced(string searchTerm, bool vegetarian, bool vegan, bool cheap, bool glutenfree, bool dairyfree, int maxminues);

	}

}