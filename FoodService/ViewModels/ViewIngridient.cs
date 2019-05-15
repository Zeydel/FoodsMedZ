using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewIngridient
	{
		public ViewIngridient(Ingredients ingredient)
		{
			Food_id = ingredient.Food_id;
			Recipe_id = ingredient.Recipe_id;
			Ingredient_name = ingredient.Ingredient_name;
			Amount = ingredient.Amount;
			Unit = ingredient.Unit;
			image = ingredient.image;
			Food = new ViewFood(ingredient.Food);
		}


		public int Food_id { get; set; }
		public int Recipe_id { get; set; }
		public string Ingredient_name { get; set; }
		public Nullable<double> Amount { get; set; }
		public Nullable<int> Unit { get; set; }
		public string image { get; set; }

		public virtual ViewFood Food { get; set; }
	}
	
}
