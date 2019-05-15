using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using FoodService;

namespace ClientSide.Controllers
{
	public class FoodController : Controller
	{
		FoodJokeServiceReference.FoodJokeService1Client foodJokeServiceClient = new FoodJokeServiceReference.FoodJokeService1Client();
		FoodTriviaServiceReference.FoodTriviaService1Client foodTriviaServiceClient = new FoodTriviaServiceReference.FoodTriviaService1Client();
		List<FoodJoke> foodJokes = new List<FoodJoke>();

		// GET: Food
		[HttpGet]
		public ActionResult getJoke()
		{
			string joke = getRandomJoke();
			return new JsonResult { Data = joke, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
		}

		//GET: Trivia
		[HttpGet]
		public ActionResult getTrivia()
		{
			string trivia = getRandomTrivia();
			return new JsonResult { Data = trivia, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
		}

		public String getRandomJoke()
		{
			var joke = "";
			var foodJokes1 = new JavaScriptSerializer().Deserialize<List<FoodJoke>>(foodJokeServiceClient.GetFoodJoke());
			var numberDistance = foodJokes1.Count;
			Random random = new Random();
			int randomnum = random.Next(numberDistance);
			joke = foodJokes1.ElementAt(randomnum).Food_joke;
			return joke;
		}

		public String getRandomTrivia()
		{
			var trivia = "";
			var foodTrivias = new JavaScriptSerializer().Deserialize<List<FoodTrivia>>(foodTriviaServiceClient.GetFoodTrivia());
			var numberDistance1 = foodTrivias.Count();
			Random random = new Random();
			int randomnum1 = random.Next(numberDistance1);
			trivia = foodTrivias.ElementAt(randomnum1).Food_trivia;
			return trivia;
		}

		public List<FoodJoke> GetFoodJokes()
		{
			return new JavaScriptSerializer().Deserialize<List<FoodJoke>>(foodJokeServiceClient.GetFoodJoke());
		}

		public List<FoodTrivia> GetFoodTrivias()
		{
			return new JavaScriptSerializer().Deserialize<List<FoodTrivia>>(foodTriviaServiceClient.GetFoodTrivia());
		}

	}
}