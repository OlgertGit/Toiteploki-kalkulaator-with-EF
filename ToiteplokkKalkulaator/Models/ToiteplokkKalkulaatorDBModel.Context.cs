﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToiteplokkKalkulaator.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToiteplokkKalkulaatorDBContext : DbContext
    {
        public ToiteplokkKalkulaatorDBContext()
            : base("name=ToiteplokkKalkulaatorDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMD> AMD { get; set; }
        public virtual DbSet<AMD_GPU> AMD_GPU { get; set; }
        public virtual DbSet<Intel> Intel { get; set; }
        public virtual DbSet<NVIDIA> NVIDIA { get; set; }
        public virtual DbSet<Optical> Optical { get; set; }
        public virtual DbSet<RAM> RAM { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<ToiteplokkPower> ToiteplokkPower { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
