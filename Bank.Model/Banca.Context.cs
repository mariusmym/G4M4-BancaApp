﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BancaDBEntities : DbContext
    {
        public BancaDBEntities()
            : base("name=BancaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Angajat> Angajat { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Cont> Cont { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
