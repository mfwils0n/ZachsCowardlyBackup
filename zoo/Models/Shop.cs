//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zoo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop
    {
        public Shop()
        {
            this.Shop_Sale_Record = new HashSet<Shop_Sale_Record>();
        }
    
        public System.Guid Shop_ID { get; set; }
        public string shop_loc { get; set; }
        public string shop_name { get; set; }
        public System.Guid Manager_Employee_ID { get; set; }
        public System.Guid Department_ID { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Shop_Sale_Record> Shop_Sale_Record { get; set; }
    }
}
