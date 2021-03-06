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
    
    public partial class sales_order
    {
        public sales_order()
        {
            this.sales_orderline = new HashSet<sales_orderline>();
        }
    
        public string OrderID { get; set; }
        public int StoreID { get; set; }
        public string StaffID { get; set; }
        public string MemberID { get; set; }
        public string DCID { get; set; }
        public double TotalAmount { get; set; }
        public System.DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public string Remark { get; set; }
    
        public virtual dealer_customer dealer_customer { get; set; }
        public virtual member member { get; set; }
        public virtual ICollection<sales_orderline> sales_orderline { get; set; }
        public virtual staff staff { get; set; }
        public virtual store store { get; set; }
    }
}
