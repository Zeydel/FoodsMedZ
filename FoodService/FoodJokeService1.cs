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
	public class FoodJokeService1 : IFoodJokeService1
	{
		public String GetFoodJoke()
		{
			masterEntities m = new masterEntities();
			List<FoodJoke> foodJokes = new List<FoodJoke>();
			var foodJokelst = from k in m.FoodJoke select k;
			foreach (var fj in foodJokelst)
			{
				foodJokes.Add(fj);
			}
			return JsonConvert.SerializeObject(foodJokes);
		}
	}
}
