using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using FoodService;

namespace ClientSide.Controllers
{
	public class FoodJamController : Controller
	{
		FoodJokeServiceReference.FoodJokeService1Client foodJokeServiceClient = new FoodJokeServiceReference.FoodJokeService1Client();
		List<FoodJoke> foodJokes = new List<FoodJoke>();

		// GET: FoodJam
		public ActionResult Food()
		{
			return View();
		}

		public String getRandomJoke()
		{
			var joke = "";
			var foodJokes1 = new JavaScriptSerializer().Deserialize<List<FoodJoke>>(foodJokeServiceClient.GetFoodJoke());
			var numberDistance = foodJokes.Count;
			Random random = new Random();
			int randomnum = random.Next(numberDistance + 1);
			joke = foodJokes1.ElementAt(randomnum).Food_joke;
			return joke;
		}

		[HttpGet]
		public List<FoodJoke> GetFoodJokes()
		{
			return new JavaScriptSerializer().Deserialize<List<FoodJoke>>(foodJokeServiceClient.GetFoodJoke());
		}

	}
}