//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIDesign
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchase_orderline
    {
        public string PurchaseID { get; set; }
        public string ItemID { get; set; }
        public int Qty { get; set; }
        public double ItemPrice { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual item item { get; set; }
        public virtual purchase_order purchase_order { get; set; }
    }
}
