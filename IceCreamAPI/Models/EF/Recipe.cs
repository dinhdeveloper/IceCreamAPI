//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceCreamAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe
    {
        public string RecipeId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CatId { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public string MainContext { get; set; }
        public string CoverImg { get; set; }
        public Nullable<System.DateTime> CreDate { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<bool> Free { get; set; }
    }
}
