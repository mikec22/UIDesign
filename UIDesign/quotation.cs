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
    
    public partial class quotation
    {
        public quotation()
        {
            this.quotation_item = new HashSet<quotation_item>();
        }
    
        public int QuotationID { get; set; }
        public string StaffID { get; set; }
        public string MemberID { get; set; }
        public string DCID { get; set; }
        public System.DateTime QuotaionDate { get; set; }
        public int Qty { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual dealer_customer dealer_customer { get; set; }
        public virtual member member { get; set; }
        public virtual ICollection<quotation_item> quotation_item { get; set; }
        public virtual staff staff { get; set; }
    }
}
