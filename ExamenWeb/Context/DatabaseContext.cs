using ExamenWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ExamenWeb.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ExamenFinalWeb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet <Contacto> Contactos { get; set; }
        public DbSet <Visita> Visitas { get; set; }
    }
}