using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSide
{
	public class ServiceFactory
	{
		private static FoodJokeServiceReference.FoodJokeService1Client f;
		public static FoodJokeServiceReference.FoodJokeService1Client getFoodJokeServiceClient()
		{
			if(f == null)
			{
				f = new FoodJokeServiceReference.FoodJokeService1Client();
			}
			return f;
		}

		private static FoodTriviaServiceReference.FoodTriviaService1Client t;
		public static FoodTriviaServiceReference.FoodTriviaService1Client getFoodTriviaServiceClient()
		{
			if (t == null)
			{
				t = new FoodTriviaServiceReference.FoodTriviaService1Client();
			}
			return t;
		}

		private static RecipeServiceReference.RecipeService1Client r;
		public static RecipeServiceReference.RecipeService1Client getRecipeServiceClient()
		{
			if (r == null)
			{
				r = new RecipeServiceReference.RecipeService1Client();
			}
			return r;
		}

		private static UserServiceReference.UserServiceClient u;
		public static UserServiceReference.UserServiceClient getUserServiceClient()
		{
			if (u == null)
			{
				u = new UserServiceReference.UserServiceClient();
			}
			return u;
		}
	}
}