﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MMS_Entities : DbContext
    {
        public MMS_Entities()
            : base("name=MMS_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<competitior_price> competitior_price { get; set; }
        public DbSet<competitor> competitor { get; set; }
        public DbSet<dealer_customer> dealer_customer { get; set; }
        public DbSet<item> item { get; set; }
        public DbSet<member> member { get; set; }
        public DbSet<member_discount> member_discount { get; set; }
        public DbSet<member_type> member_type { get; set; }
        public DbSet<purchase_order> purchase_order { get; set; }
        public DbSet<purchase_orderline> purchase_orderline { get; set; }
        public DbSet<quotation> quotation { get; set; }
        public DbSet<quotation_item> quotation_item { get; set; }
        public DbSet<reserve_request> reserve_request { get; set; }
        public DbSet<sales_order> sales_order { get; set; }
        public DbSet<sales_orderline> sales_orderline { get; set; }
        public DbSet<staff> staff { get; set; }
        public DbSet<store> store { get; set; }
        public DbSet<store_item> store_item { get; set; }
    }
}