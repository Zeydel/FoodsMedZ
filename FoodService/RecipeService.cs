using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoodService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class RecipeService : IRecipeService
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

        public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}

	}
}
