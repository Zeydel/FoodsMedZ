using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewFood
	{
		public ViewFood(Food food)
		{
			Food_id = food.Food_id;
			Food_name = food.Food_name;
			image = food.image;
			Nutrition = new HashSet<ViewNutrition>();
			foreach (Nutrition n in food.Nutrition)
			{
				Nutrition.Add(new ViewNutrition(n));
			}
		}

		public int Food_id { get; set; }
		public string Food_name { get; set; }
		public string image { get; set; }

		public virtual ICollection<ViewNutrition> Nutrition { get; set; }
	}
}
