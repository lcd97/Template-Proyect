using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace XalliHotel.Models
{
    public class Hotel : DbContext
    {
        //DEFINICION DE LAS TABLAS DE LA BASE DE DATOS

        //SCHEMA INVENTORY
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleDeEntrada> DetallesDeEntrada { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<TipoDeEntrada> TiposDeEntrada { get; set; }
        public DbSet<UnidadDeMedida> UnidadesDeMedida { get; set; }

        //CREACION DEL MODELO Y RELIMINACION DE COMPORTAMIENTO DE EF
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}