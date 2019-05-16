using FoodService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientSide.Models
{
    public class UserFavRecipes
    {
        [Required]
        public List<int> favorites{ get; set; }

        [Required]
        public List<Recipe> recipes { get; set; }
    }
}
