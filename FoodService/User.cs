//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodService
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
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
        public string favorites { get; set; }
        public string favJokes { get; set; }
        public string favTrivia { get; set; }
    }
}
