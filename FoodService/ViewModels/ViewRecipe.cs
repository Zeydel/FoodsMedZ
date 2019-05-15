using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewRecipe
	{
		public ViewRecipe(Recipe recipe)
		{
			Recipe_id = recipe.Recipe_id;
			Recipe_name = recipe.Recipe_name;
			Recipe_minutes = recipe.Recipe_minutes;
			Recipe_veg = recipe.Recipe_veg;
			Recipe_vegan = recipe.Recipe_vegan;
			cheap = recipe.cheap;
			sustainable = recipe.sustainable;
			glutenfree = recipe.glutenfree;
			dairyfree = recipe.dairyfree;
			image = recipe.image;
			Instructions = recipe.Instructions;
			imageTyp = recipe.imageTyp;
			Ingredients = new HashSet<ViewIngridient>();
			foreach(Ingredients i in recipe.Ingredients)
			{
				Ingredients.Add(new ViewIngridient(i));
			}
		}

		public int Recipe_id { get; set; }
		public string Recipe_name { get; set; }
		public Nullable<int> Recipe_minutes { get; set; }
		public Nullable<bool> Recipe_veg { get; set; }
		public Nullable<bool> Recipe_vegan { get; set; }
		public Nullable<bool> cheap { get; set; }
		public Nullable<bool> sustainable { get; set; }
		public Nullable<bool> glutenfree { get; set; }
		public Nullable<bool> dairyfree { get; set; }
		public string image { get; set; }
		public string Instructions { get; set; }
		public string imageTyp { get; set; }

		public virtual ICollection<ViewIngridient> Ingredients { get; set; }

	}
}
