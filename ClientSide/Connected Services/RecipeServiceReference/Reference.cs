﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSide.RecipeServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RecipeServiceReference.IRecipeService1")]
    public interface IRecipeService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getRecipesResponse")]
        FoodService.Recipe getRecipes(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getRecipesResponse")]
        System.Threading.Tasks.Task<FoodService.Recipe> getRecipesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/addRecipe", ReplyAction="http://tempuri.org/IRecipeService1/addRecipeResponse")]
        void addRecipe(int recipe_id, string recipe_name, int recipe_minutes, bool recipe_veg, bool recipe_vegan, bool cheap, bool sustainable, bool glutenfree, bool dairyfree, string image, string instruction, string imageTyp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/addRecipe", ReplyAction="http://tempuri.org/IRecipeService1/addRecipeResponse")]
        System.Threading.Tasks.Task addRecipeAsync(int recipe_id, string recipe_name, int recipe_minutes, bool recipe_veg, bool recipe_vegan, bool cheap, bool sustainable, bool glutenfree, bool dairyfree, string image, string instruction, string imageTyp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/findRecipesByName", ReplyAction="http://tempuri.org/IRecipeService1/findRecipesByNameResponse")]
        string findRecipesByName(string recipe_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/findRecipesByName", ReplyAction="http://tempuri.org/IRecipeService1/findRecipesByNameResponse")]
        System.Threading.Tasks.Task<string> findRecipesByNameAsync(string recipe_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/findRecipesById", ReplyAction="http://tempuri.org/IRecipeService1/findRecipesByIdResponse")]
        string findRecipesById(int recipe_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/findRecipesById", ReplyAction="http://tempuri.org/IRecipeService1/findRecipesByIdResponse")]
        System.Threading.Tasks.Task<string> findRecipesByIdAsync(int recipe_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getAllRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getAllRecipesResponse")]
        string getAllRecipes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getAllRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getAllRecipesResponse")]
        System.Threading.Tasks.Task<string> getAllRecipesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecipeService1Channel : ClientSide.RecipeServiceReference.IRecipeService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecipeService1Client : System.ServiceModel.ClientBase<ClientSide.RecipeServiceReference.IRecipeService1>, ClientSide.RecipeServiceReference.IRecipeService1 {
        
        public RecipeService1Client() {
        }
        
        public RecipeService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecipeService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecipeService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecipeService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FoodService.Recipe getRecipes(int id) {
            return base.Channel.getRecipes(id);
        }
        
        public System.Threading.Tasks.Task<FoodService.Recipe> getRecipesAsync(int id) {
            return base.Channel.getRecipesAsync(id);
        }
        
        public void addRecipe(int recipe_id, string recipe_name, int recipe_minutes, bool recipe_veg, bool recipe_vegan, bool cheap, bool sustainable, bool glutenfree, bool dairyfree, string image, string instruction, string imageTyp) {
            base.Channel.addRecipe(recipe_id, recipe_name, recipe_minutes, recipe_veg, recipe_vegan, cheap, sustainable, glutenfree, dairyfree, image, instruction, imageTyp);
        }
        
        public System.Threading.Tasks.Task addRecipeAsync(int recipe_id, string recipe_name, int recipe_minutes, bool recipe_veg, bool recipe_vegan, bool cheap, bool sustainable, bool glutenfree, bool dairyfree, string image, string instruction, string imageTyp) {
            return base.Channel.addRecipeAsync(recipe_id, recipe_name, recipe_minutes, recipe_veg, recipe_vegan, cheap, sustainable, glutenfree, dairyfree, image, instruction, imageTyp);
        }
        
        public string findRecipesByName(string recipe_name) {
            return base.Channel.findRecipesByName(recipe_name);
        }
        
        public System.Threading.Tasks.Task<string> findRecipesByNameAsync(string recipe_name) {
            return base.Channel.findRecipesByNameAsync(recipe_name);
        }
        
        public string findRecipesById(int recipe_id) {
            return base.Channel.findRecipesById(recipe_id);
        }
        
        public System.Threading.Tasks.Task<string> findRecipesByIdAsync(int recipe_id) {
            return base.Channel.findRecipesByIdAsync(recipe_id);
        }
        
        public string getAllRecipes() {
            return base.Channel.getAllRecipes();
        }
        
        public System.Threading.Tasks.Task<string> getAllRecipesAsync() {
            return base.Channel.getAllRecipesAsync();
        }
    }
}
