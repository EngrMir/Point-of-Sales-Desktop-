﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Sales
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POS_Sales : DbContext
    {
        public POS_Sales()
            : base("name=POS_Sales")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }
        public virtual DbSet<SalePayment> SalePayments { get; set; }
        public virtual DbSet<SaleReturnReceive> SaleReturnReceives { get; set; }
        public virtual DbSet<SaleReturnReceiveDetail> SaleReturnReceiveDetails { get; set; }
    }
}
