﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KravadooEntities1 : DbContext
    {
        public KravadooEntities1()
            : base("name=KravadooEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Krava> Krava { get; set; }
        public virtual DbSet<Pasmina> Pasmina { get; set; }
        public virtual DbSet<ProizvodnjaMlijeka> ProizvodnjaMlijeka { get; set; }
    }
}