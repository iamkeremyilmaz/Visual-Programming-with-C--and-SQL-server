﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace midtermproject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class branchesEntities1 : DbContext
    {
        public branchesEntities1()
            : base("name=branchesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessory> Accessory { get; set; }
  
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}
