//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LNTKKiosk.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grocery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grocery()
        {
            this.Stocks = new HashSet<Stock>();
            this.Recipes = new HashSet<Recipe>();
        }
    
        public int GroceryId { get; set; }
        public int CodeId { get; set; }
        public Nullable<int> Unit { get; set; }
    
        public virtual Code Code { get; set; }
        public virtual Code Code1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}