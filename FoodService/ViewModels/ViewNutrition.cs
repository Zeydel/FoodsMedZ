using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewNutrition
	{
		public ViewNutrition(Nutrition nutrition)
		{
			Nutrition_id = nutrition.Nutrition_id;
			name = nutrition.name;
			amount = nutrition.amount;
			unit = nutrition.unit;
			Ingredient_id = nutrition.Ingredient_id;
		}
		public int Nutrition_id { get; set; }
		public string name { get; set; }
		public Nullable<int> amount { get; set; }
		public Nullable<int> unit { get; set; }
		public Nullable<int> Ingredient_id { get; set; }
	}
}
