using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI;
using API_Reciever.ServiceReference1;

namespace DBRecipeFetcher
{
    class Program
    {
        static void Main(string[] args)
        {

            WebRequest request = WebRequest.Create("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/479111/information");
            request.Method = "GET";
            request.Headers.Add("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.Headers.Add("X-RapidAPI-Key", "ea8b3c331cmshe7e397ea99737e2p1a433ajsn83b9197c861f");


            WebResponse res = request.GetResponse();
            string output = null;
            Recipe recipe = new Recipe();
            using (var reader = new StreamReader(res.GetResponseStream()))
            {
                output = reader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                Recipe rcp = js.Deserialize<Recipe>(output);

                System.Console.WriteLine(rcp.title);

                recipe = rcp;
               
            }
            //System.Console.WriteLine(output);  


            API_Reciever.ServiceReference1.RecipeService1Client client = new API_Reciever.ServiceReference1.RecipeService1Client();

            client.addRecipe(recipe.id, recipe.title, recipe.readyInMinutes, recipe.vegetarian, recipe.vegan, recipe.cheap,
                recipe.sustainable, recipe.glutenFree, recipe.dairyFree, recipe.image, recipe.instructions, recipe.imageType);


            Console.ReadLine();

        }

    }

    class Recipe
    {
        public Boolean vegetarian { get; set; }
        public Boolean vegan { get; set; }
        public Boolean glutenFree { get; set; }
        public Boolean dairyFree { get; set; }
        public Boolean veryHealthy { get; set; }
        public Boolean cheap { get; set; }
        public Boolean veryPopular { get; set; }
        public Boolean sustainable { get; set; }
        public Boolean lowFodmap { get; set; }
        public Boolean ketogenic { get; set; }
        public Boolean whole30 { get; set; }
        public double weightWatcherSmartPoints { get; set; }
        public int servings { get; set; }
        public int aggregateLikes { get; set; }
        public int id { get; set; }
        public int readyInMinutes { get; set; }
        public String gaps { get; set; }
        public String sourceUrl { get; set; }
        public String spoonacularSourceUrl { get; set; }
        public String creditText { get; set; }
        public String sourceName { get; set; }
        public String title { get; set; }
        public String image { get; set; }
        public String imageType { get; set; }
        public String instructions { get; set; }
        //public List<Ingredient> extendedIngredients { get; set; }
    }

    class Ingredient
    {
        public int id { get; set; }
        public double amount { get; set; }
        public String aisle { get; set; }
        public String image { get; set; }
        public String name { get; set; }
        public String unit { get; set; }
        public String unitShort { get; set; }
        public String unitLong { get; set; }
        public String originalString { get; set; }
        public String metaInformation { get; set; }
    }

}
