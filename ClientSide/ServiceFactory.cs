using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSide
{
	public class ServiceFactory
	{
		private static FoodJokeServiceReference.FoodJokeServiceClient f;
		public static FoodJokeServiceReference.FoodJokeServiceClient getFoodJokeServiceClient()
		{
			if(f == null)
			{
				f = new FoodJokeServiceReference.FoodJokeServiceClient();
			}
			return f;
		}

		private static FoodTriviaServiceReference.FoodTriviaServiceClient t;
		public static FoodTriviaServiceReference.FoodTriviaServiceClient getFoodTriviaServiceClient()
		{
			if (t == null)
			{
				t = new FoodTriviaServiceReference.FoodTriviaServiceClient();
			}
			return t;
		}

		private static RecipeServiceReference.RecipeServiceClient r;
		public static RecipeServiceReference.RecipeServiceClient getRecipeServiceClient()
		{
			if (r == null)
			{
				r = new RecipeServiceReference.RecipeServiceClient();
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