﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinancieraAmetrano.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDFinancieraEntities : DbContext
    {
        public BDFinancieraEntities()
            : base("name=BDFinancieraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
    }
}