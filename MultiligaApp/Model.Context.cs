﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiligaApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class multiligaEntities : DbContext
    {
        public multiligaEntities()
            : base("name=multiligaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<druzyna> druzyna { get; set; }
        public virtual DbSet<dyscyplina> dyscyplina { get; set; }
        public virtual DbSet<kwalifikacje> kwalifikacje { get; set; }
        public virtual DbSet<organizator> organizator { get; set; }
        public virtual DbSet<pakiet_startowy> pakiet_startowy { get; set; }
        public virtual DbSet<pracownik> pracownik { get; set; }
        public virtual DbSet<trasa> trasa { get; set; }
        public virtual DbSet<uzytkownik> uzytkownik { get; set; }
        public virtual DbSet<wplata> wplata { get; set; }
        public virtual DbSet<wynik> wynik { get; set; }
        public virtual DbSet<wyscig> wyscig { get; set; }
        public virtual DbSet<zawodnik> zawodnik { get; set; }
        public virtual DbSet<zawodnik_druzyna> zawodnik_druzyna { get; set; }
        public virtual DbSet<zawodnik_zawody> zawodnik_zawody { get; set; }
        public virtual DbSet<zawody> zawody { get; set; }
    }
}
