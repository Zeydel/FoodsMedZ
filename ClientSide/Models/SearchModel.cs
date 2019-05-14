using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientSide.Models
{
	public class SearchModel
	{
		[Required]
		public string SearchTerm { get; set; }

		public bool Vegetarian { get; set; }

		public bool Vegan { get; set; }

		public bool Cheap { get; set; }

		public bool Glutenfree { get; set; }

		public bool Dairyfree { get; set; }

		public int? maxMinutes { get; set; }
	}
}