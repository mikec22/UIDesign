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
    
    public partial class purchase_order
    {
        public purchase_order()
        {
            this.purchase_orderline = new HashSet<purchase_orderline>();
        }
    
        public string PurchaseID { get; set; }
        public string StaffID { get; set; }
        public int StoreID { get; set; }
        public string CompanyName { get; set; }
        public System.DateTime OrderDate { get; set; }
        public double Total { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual store store { get; set; }
        public virtual ICollection<purchase_orderline> purchase_orderline { get; set; }
    }
}