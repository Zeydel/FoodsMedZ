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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Recipe", Namespace="http://schemas.datacontract.org/2004/07/FoodService")]
    [System.SerializableAttribute()]
    public partial class Recipe : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Ingredients[] IngredientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstructionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Recipe_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Recipe_minutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Recipe_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> Recipe_vegField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> Recipe_veganField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> cheapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> dairyfreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> glutenfreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageTypField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> sustainableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.users[] usersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Ingredients[] Ingredients {
            get {
                return this.IngredientsField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsField, value) != true)) {
                    this.IngredientsField = value;
                    this.RaisePropertyChanged("Ingredients");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Instructions {
            get {
                return this.InstructionsField;
            }
            set {
                if ((object.ReferenceEquals(this.InstructionsField, value) != true)) {
                    this.InstructionsField = value;
                    this.RaisePropertyChanged("Instructions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Recipe_id {
            get {
                return this.Recipe_idField;
            }
            set {
                if ((this.Recipe_idField.Equals(value) != true)) {
                    this.Recipe_idField = value;
                    this.RaisePropertyChanged("Recipe_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Recipe_minutes {
            get {
                return this.Recipe_minutesField;
            }
            set {
                if ((this.Recipe_minutesField.Equals(value) != true)) {
                    this.Recipe_minutesField = value;
                    this.RaisePropertyChanged("Recipe_minutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recipe_name {
            get {
                return this.Recipe_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Recipe_nameField, value) != true)) {
                    this.Recipe_nameField = value;
                    this.RaisePropertyChanged("Recipe_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Recipe_veg {
            get {
                return this.Recipe_vegField;
            }
            set {
                if ((this.Recipe_vegField.Equals(value) != true)) {
                    this.Recipe_vegField = value;
                    this.RaisePropertyChanged("Recipe_veg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Recipe_vegan {
            get {
                return this.Recipe_veganField;
            }
            set {
                if ((this.Recipe_veganField.Equals(value) != true)) {
                    this.Recipe_veganField = value;
                    this.RaisePropertyChanged("Recipe_vegan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> cheap {
            get {
                return this.cheapField;
            }
            set {
                if ((this.cheapField.Equals(value) != true)) {
                    this.cheapField = value;
                    this.RaisePropertyChanged("cheap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> dairyfree {
            get {
                return this.dairyfreeField;
            }
            set {
                if ((this.dairyfreeField.Equals(value) != true)) {
                    this.dairyfreeField = value;
                    this.RaisePropertyChanged("dairyfree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> glutenfree {
            get {
                return this.glutenfreeField;
            }
            set {
                if ((this.glutenfreeField.Equals(value) != true)) {
                    this.glutenfreeField = value;
                    this.RaisePropertyChanged("glutenfree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imageTyp {
            get {
                return this.imageTypField;
            }
            set {
                if ((object.ReferenceEquals(this.imageTypField, value) != true)) {
                    this.imageTypField = value;
                    this.RaisePropertyChanged("imageTyp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> sustainable {
            get {
                return this.sustainableField;
            }
            set {
                if ((this.sustainableField.Equals(value) != true)) {
                    this.sustainableField = value;
                    this.RaisePropertyChanged("sustainable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.users[] users {
            get {
                return this.usersField;
            }
            set {
                if ((object.ReferenceEquals(this.usersField, value) != true)) {
                    this.usersField = value;
                    this.RaisePropertyChanged("users");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ingredients", Namespace="http://schemas.datacontract.org/2004/07/FoodService")]
    [System.SerializableAttribute()]
    public partial class Ingredients : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Food FoodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Food_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ingredient_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Recipe RecipeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Recipe_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> UnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Food Food {
            get {
                return this.FoodField;
            }
            set {
                if ((object.ReferenceEquals(this.FoodField, value) != true)) {
                    this.FoodField = value;
                    this.RaisePropertyChanged("Food");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Food_id {
            get {
                return this.Food_idField;
            }
            set {
                if ((this.Food_idField.Equals(value) != true)) {
                    this.Food_idField = value;
                    this.RaisePropertyChanged("Food_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ingredient_name {
            get {
                return this.Ingredient_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Ingredient_nameField, value) != true)) {
                    this.Ingredient_nameField = value;
                    this.RaisePropertyChanged("Ingredient_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Recipe Recipe {
            get {
                return this.RecipeField;
            }
            set {
                if ((object.ReferenceEquals(this.RecipeField, value) != true)) {
                    this.RecipeField = value;
                    this.RaisePropertyChanged("Recipe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Recipe_id {
            get {
                return this.Recipe_idField;
            }
            set {
                if ((this.Recipe_idField.Equals(value) != true)) {
                    this.Recipe_idField = value;
                    this.RaisePropertyChanged("Recipe_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Unit {
            get {
                return this.UnitField;
            }
            set {
                if ((this.UnitField.Equals(value) != true)) {
                    this.UnitField = value;
                    this.RaisePropertyChanged("Unit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="users", Namespace="http://schemas.datacontract.org/2004/07/FoodService")]
    [System.SerializableAttribute()]
    public partial class users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string First_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Last_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Recipe[] RecipeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> dairyfreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> glutenfreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> heightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> veganField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> vegetarianField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> weightField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_name {
            get {
                return this.First_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.First_nameField, value) != true)) {
                    this.First_nameField = value;
                    this.RaisePropertyChanged("First_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_name {
            get {
                return this.Last_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Last_nameField, value) != true)) {
                    this.Last_nameField = value;
                    this.RaisePropertyChanged("Last_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Recipe[] Recipe {
            get {
                return this.RecipeField;
            }
            set {
                if ((object.ReferenceEquals(this.RecipeField, value) != true)) {
                    this.RecipeField = value;
                    this.RaisePropertyChanged("Recipe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_id {
            get {
                return this.User_idField;
            }
            set {
                if ((this.User_idField.Equals(value) != true)) {
                    this.User_idField = value;
                    this.RaisePropertyChanged("User_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> dairyfree {
            get {
                return this.dairyfreeField;
            }
            set {
                if ((this.dairyfreeField.Equals(value) != true)) {
                    this.dairyfreeField = value;
                    this.RaisePropertyChanged("dairyfree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> gender {
            get {
                return this.genderField;
            }
            set {
                if ((this.genderField.Equals(value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> glutenfree {
            get {
                return this.glutenfreeField;
            }
            set {
                if ((this.glutenfreeField.Equals(value) != true)) {
                    this.glutenfreeField = value;
                    this.RaisePropertyChanged("glutenfree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> height {
            get {
                return this.heightField;
            }
            set {
                if ((this.heightField.Equals(value) != true)) {
                    this.heightField = value;
                    this.RaisePropertyChanged("height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> vegan {
            get {
                return this.veganField;
            }
            set {
                if ((this.veganField.Equals(value) != true)) {
                    this.veganField = value;
                    this.RaisePropertyChanged("vegan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> vegetarian {
            get {
                return this.vegetarianField;
            }
            set {
                if ((this.vegetarianField.Equals(value) != true)) {
                    this.vegetarianField = value;
                    this.RaisePropertyChanged("vegetarian");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> weight {
            get {
                return this.weightField;
            }
            set {
                if ((this.weightField.Equals(value) != true)) {
                    this.weightField = value;
                    this.RaisePropertyChanged("weight");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Food", Namespace="http://schemas.datacontract.org/2004/07/FoodService")]
    [System.SerializableAttribute()]
    public partial class Food : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Food_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Food_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Ingredients[] IngredientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Nutrition[] NutritionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Food_id {
            get {
                return this.Food_idField;
            }
            set {
                if ((this.Food_idField.Equals(value) != true)) {
                    this.Food_idField = value;
                    this.RaisePropertyChanged("Food_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Food_name {
            get {
                return this.Food_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Food_nameField, value) != true)) {
                    this.Food_nameField = value;
                    this.RaisePropertyChanged("Food_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Ingredients[] Ingredients {
            get {
                return this.IngredientsField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsField, value) != true)) {
                    this.IngredientsField = value;
                    this.RaisePropertyChanged("Ingredients");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Nutrition[] Nutrition {
            get {
                return this.NutritionField;
            }
            set {
                if ((object.ReferenceEquals(this.NutritionField, value) != true)) {
                    this.NutritionField = value;
                    this.RaisePropertyChanged("Nutrition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unit {
            get {
                return this.unitField;
            }
            set {
                if ((object.ReferenceEquals(this.unitField, value) != true)) {
                    this.unitField = value;
                    this.RaisePropertyChanged("unit");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Nutrition", Namespace="http://schemas.datacontract.org/2004/07/FoodService")]
    [System.SerializableAttribute()]
    public partial class Nutrition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientSide.RecipeServiceReference.Food FoodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Ingredient_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Nutrition_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> unitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientSide.RecipeServiceReference.Food Food {
            get {
                return this.FoodField;
            }
            set {
                if ((object.ReferenceEquals(this.FoodField, value) != true)) {
                    this.FoodField = value;
                    this.RaisePropertyChanged("Food");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Ingredient_id {
            get {
                return this.Ingredient_idField;
            }
            set {
                if ((this.Ingredient_idField.Equals(value) != true)) {
                    this.Ingredient_idField = value;
                    this.RaisePropertyChanged("Ingredient_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nutrition_id {
            get {
                return this.Nutrition_idField;
            }
            set {
                if ((this.Nutrition_idField.Equals(value) != true)) {
                    this.Nutrition_idField = value;
                    this.RaisePropertyChanged("Nutrition_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> unit {
            get {
                return this.unitField;
            }
            set {
                if ((this.unitField.Equals(value) != true)) {
                    this.unitField = value;
                    this.RaisePropertyChanged("unit");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RecipeServiceReference.IRecipeService1")]
    public interface IRecipeService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getRecipesResponse")]
        ClientSide.RecipeServiceReference.Recipe getRecipes(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService1/getRecipes", ReplyAction="http://tempuri.org/IRecipeService1/getRecipesResponse")]
        System.Threading.Tasks.Task<ClientSide.RecipeServiceReference.Recipe> getRecipesAsync(int id);
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
        
        public ClientSide.RecipeServiceReference.Recipe getRecipes(int id) {
            return base.Channel.getRecipes(id);
        }
        
        public System.Threading.Tasks.Task<ClientSide.RecipeServiceReference.Recipe> getRecipesAsync(int id) {
            return base.Channel.getRecipesAsync(id);
        }
    }
}