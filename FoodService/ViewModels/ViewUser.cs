using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.ViewModels
{
	class ViewUser
	{
		public ViewUser(User user)
		{
			User_id = user.User_id;
			First_name = user.First_name;
			Last_name = user.Last_name;
			userName = user.userName;
			password = user.password;
			weight = user.weight;
			height = user.height;
			gender = user.gender;
			vegetarian = user.vegetarian;
			vegan = user.vegan;
			dairyfree = user.dairyfree;
			glutenfree = user.glutenfree;
			this.FoodJoke = new HashSet<ViewFoodJoke>();
			foreach(FoodJoke fj in user.FoodJoke)
			{
				FoodJoke.Add(new ViewFoodJoke(fj));
			}
			this.FoodTrivia = new HashSet<ViewFoodTrivia>();
			foreach (FoodTrivia ft in user.FoodTrivia)
			{
				FoodTrivia.Add(new ViewFoodTrivia(ft));
			}
			this.Recipe = new HashSet<ViewRecipe>();
			foreach (Recipe r in user.Recipe)
			{
				Recipe.Add(new ViewRecipe(r));
			}
		}

		public int User_id { get; set; }
		public string First_name { get; set; }
		public string Last_name { get; set; }
		public string userName { get; set; }
		public string password { get; set; }
		public Nullable<double> weight { get; set; }
		public Nullable<double> height { get; set; }
		public Nullable<bool> gender { get; set; }
		public Nullable<bool> vegetarian { get; set; }
		public Nullable<bool> vegan { get; set; }
		public Nullable<bool> dairyfree { get; set; }
		public Nullable<bool> glutenfree { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViewFoodJoke> FoodJoke { get; set; }
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViewFoodTrivia> FoodTrivia { get; set; }
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViewRecipe> Recipe { get; set; }
	}
}
