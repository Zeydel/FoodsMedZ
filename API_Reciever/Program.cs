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
using Newtonsoft.Json;

namespace DBRecipeFetcher
{
    class Program
    {
        static void Main(string[] args)
        {

			API_Reciever.ServiceReference1.RecipeServiceClient client = new API_Reciever.ServiceReference1.RecipeServiceClient();
			WebRequest request = WebRequest.Create("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/479122/information");
            request.Method = "GET";
			Tuple<string, string> apiinfo = JsonConvert.DeserializeObject<Tuple<string, string>>(client.getApiInformation());

			request.Headers.Add("X-RapidAPI-Host", apiinfo.Item1);
            request.Headers.Add("X-RapidAPI-Key", apiinfo.Item2);


            WebResponse res = request.GetResponse();
            string output = null;
            Recipe recipe = new Recipe();
            List<Ingredients> finalList = new List<Ingredients>();
            using (var reader = new StreamReader(res.GetResponseStream()))
            {
                output = reader.ReadToEnd();

                //JavaScriptSerializer js = new JavaScriptSerializer();
                //Recipe rcp = js.Deserialize<Recipe>(output);

                Recipe rcp = JsonConvert.DeserializeObject<Recipe>(output);

                System.Console.WriteLine(rcp.title);
                System.Console.WriteLine(rcp.extendedIngredients[0].name);

                recipe = rcp;

                List<Ingredients> ingrList = new List<Ingredients>();

                foreach(Ingredient item in rcp.extendedIngredients)
                {
                    Ingredients current = new Ingredients();

                    current.Ingredient_id = item.id;
                    current.Recipe_id = rcp.id;
                    current.Ingredient_name = item.name;
                    current.Amount = item.amount;
                    current.Unit = item.unit;

                    ingrList.Add(current);
                }
                finalList = ingrList;
            }
            //System.Console.WriteLine(output);  


            int size = finalList.Count();

            Ingredients[] array = new Ingredients[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = finalList[i];
            }
            

           

            client.addRecipe(recipe.id, recipe.title, recipe.readyInMinutes, recipe.vegetarian, recipe.vegan, recipe.cheap,
                recipe.sustainable, recipe.glutenFree, recipe.dairyFree, recipe.image, recipe.instructions, recipe.imageType, array);


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
        public List<Ingredient> extendedIngredients { get; set; }
    }

    class Ingredient
    {
        public int id { get; set; }
        public String aisle { get; set; }
        public String image { get; set; }
        public String consistency { get; set; }
        public String name { get; set; }
        public String originalString { get; set; }
        public String originalName { get; set; }
        public double amount { get; set; }
        public String unit { get; set; }
    }

}
