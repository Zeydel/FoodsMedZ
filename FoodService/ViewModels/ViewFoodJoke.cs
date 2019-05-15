using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	public class ViewFoodJoke
	{
		public ViewFoodJoke(FoodJoke foodJoke)
		{
			Id = foodJoke.Id;
			Food_joke = foodJoke.Food_joke;
		}

		public int Id { get; set; }
		public string Food_joke { get; set; }

	}
}
