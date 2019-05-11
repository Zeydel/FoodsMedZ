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
        [OperationContract]
        Recipe getRecipes(int id);

        [OperationContract]
        void addRecipe(int recipe_id, String recipe_name, int recipe_minutes, Boolean recipe_veg, Boolean recipe_vegan,
            Boolean cheap, Boolean sustainable, Boolean glutenfree, Boolean dairyfree, String image, String instruction,
            String imageTyp);

		[OperationContract]
		String findRecipesByName(String recipe_name);

		[OperationContract]
		String getAllRecipes();

	}

}