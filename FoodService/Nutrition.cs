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
    
    public partial class Nutrition
    {
        public int Nutrition_id { get; set; }
        public string name { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<int> unit { get; set; }
    
        public virtual Food Food { get; set; }
    }
}
