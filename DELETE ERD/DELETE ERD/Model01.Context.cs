﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DELETE_ERD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProdLevyORDERSEntities : DbContext
    {
        public ProdLevyORDERSEntities()
            : base("name=ProdLevyORDERSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<CUSTOMER_ADDRESS> CUSTOMER_ADDRESS { get; set; }
        public virtual DbSet<CUSTOMER_CATEGORY> CUSTOMER_CATEGORY { get; set; }
        public virtual DbSet<CUSTOMER_CONTACT> CUSTOMER_CONTACT { get; set; }
        public virtual DbSet<CUSTOMER_CONTACT_PHONE> CUSTOMER_CONTACT_PHONE { get; set; }
        public virtual DbSet<CUSTOMER_CONTACT_TYPE> CUSTOMER_CONTACT_TYPE { get; set; }
        public virtual DbSet<CUSTOMER_CONTACT_WEB_RESPONSIBILITY> CUSTOMER_CONTACT_WEB_RESPONSIBILITY { get; set; }
        public virtual DbSet<CUSTOMER_CREDIT_CARD> CUSTOMER_CREDIT_CARD { get; set; }
        public virtual DbSet<CUSTOMER_CREDIT_CARD_SUITE> CUSTOMER_CREDIT_CARD_SUITE { get; set; }
        public virtual DbSet<CUSTOMER_GENERAL_PREFERENCES> CUSTOMER_GENERAL_PREFERENCES { get; set; }
        public virtual DbSet<CUSTOMER_NOTE> CUSTOMER_NOTE { get; set; }
        public virtual DbSet<CUSTOMER_PAR> CUSTOMER_PAR { get; set; }
        public virtual DbSet<CUSTOMER_PAR_LINES> CUSTOMER_PAR_LINES { get; set; }
        public virtual DbSet<CUSTOMER_PREFERENCE> CUSTOMER_PREFERENCE { get; set; }
        public virtual DbSet<CUSTOMER_PREFERENCE_LIST> CUSTOMER_PREFERENCE_LIST { get; set; }
        public virtual DbSet<CUSTOMER_PREFERENCE_LOCATION_DETAILS> CUSTOMER_PREFERENCE_LOCATION_DETAILS { get; set; }
        public virtual DbSet<CUSTOMER_SUITE> CUSTOMER_SUITE { get; set; }
        public virtual DbSet<CUSTOMER_SUITE_NOTE> CUSTOMER_SUITE_NOTE { get; set; }
        public virtual DbSet<CUSTOMER_SUITE_PREFERENCE> CUSTOMER_SUITE_PREFERENCE { get; set; }
        public virtual DbSet<CUSTOMER_TYPE> CUSTOMER_TYPE { get; set; }
        public virtual DbSet<SUITE> SUITEs { get; set; }
        public virtual DbSet<SUITE_PREFERENCE_LIST> SUITE_PREFERENCE_LIST { get; set; }
        public virtual DbSet<SUITE_PREFERENCE_LOCATION_DETAILS> SUITE_PREFERENCE_LOCATION_DETAILS { get; set; }
        public virtual DbSet<SUITE_TYPE> SUITE_TYPE { get; set; }
    }
}
