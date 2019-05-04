using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoodService
{
	[ServiceContract]
	public interface IRecipeService
	{
        [OperationContract]
        Recipe getRecipes(int id);

	}
    
}
