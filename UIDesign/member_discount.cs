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
    
    public partial class member_discount
    {
        public int TypeID { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public double discount { get; set; }
    
        public virtual member_type member_type { get; set; }
    }
}
