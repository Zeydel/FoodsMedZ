using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewFoodTrivia
	{
		public ViewFoodTrivia(FoodTrivia foodTrivia)
		{
			Id = foodTrivia.Id;
			Food_trivia = foodTrivia.Food_trivia;
		}

		public int Id { get; set; }
		public string Food_trivia { get; set; }

	}
}
