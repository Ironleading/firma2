﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firma2.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbisTAKİPEntities : DbContext
    {
        public DbisTAKİPEntities()
            : base("name=DbisTAKİPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMIN { get; set; }
        public virtual DbSet<COMPANIES> COMPANIES { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<MISSION_DETAIL> MISSION_DETAIL { get; set; }
        public virtual DbSet<TASKS> TASKS { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<CAGRIFIRMA> CAGRIFIRMA { get; set; }
        public virtual DbSet<CAGRIDETAY> CAGRIDETAY { get; set; }
        public virtual DbSet<MESAJLAR> MESAJLAR { get; set; }
    }
}
