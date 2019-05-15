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
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

	public class FoodTriviaService1 : IFoodTriviaService1
	{
		public String GetFoodTrivia()
		{
			masterEntities m = new masterEntities();
			List<FoodTrivia> foodTrivias= new List<FoodTrivia>();
			var foodTrivialst = from k in m.FoodTrivia select k;
			foreach (FoodTrivia ft in foodTrivialst)
			{
				foodTrivias.Add(ft);
			}
			return JsonConvert.SerializeObject(foodTrivias);
		}
	}
}
