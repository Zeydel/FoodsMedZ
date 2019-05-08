using System;
using System.ComponentModel.DataAnnotations;

namespace ClientSide.Models
{
    public class SignUpModel
    {
		[Required(ErrorMessage = "Please type in your first name")]
		public string First_name { get; set; }


		[Required(ErrorMessage = "Please type in your last name")]
		public string Last_name { get; set; }


		[Required(ErrorMessage = "You must choose a username")]
		public string userName { get; set; }


		[Required(ErrorMessage = "Choose a password for your account")]
		public string password { get; set; }

		[Required(ErrorMessage = "Please type in your weight")]
		public Nullable<double> weight { get; set; }

		[Required(ErrorMessage = "Please type ind height")]
		public Nullable<double> height { get; set; }


		[Required(ErrorMessage = "Choose your gender")]
		public Nullable<bool> gender { get; set; }


		[Required(ErrorMessage = "Let us know if you're a vegetarian")]
		public Nullable<bool> vegetarian { get; set; }


		[Required(ErrorMessage = "Let us know if you're a vegan")]
		public Nullable<bool> vegan { get; set; }


		[Required(ErrorMessage = "Let us know if your diet is dairyfree")]
		public Nullable<bool> dairyfree { get; set; }


		[Required(ErrorMessage = "Let us know if your diet is glutenfree")]
		public Nullable<bool> glutenfree { get; set; }


	}

}
