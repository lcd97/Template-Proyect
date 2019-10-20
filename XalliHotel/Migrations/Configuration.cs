namespace XalliHotel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using XalliHotel.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<XalliHotel.Models.Hotel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "XalliHotel.Models.Hotel";
        }

        protected override void Seed(XalliHotel.Models.Hotel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //TABLA CATEGORIAS
            context.Categorias.AddOrUpdate(
                h => h.codCat,
                new Categoria { codCat = "C0001", descCat = "Bebidas", estadoCat = true },
                new Categoria { codCat = "C0002", descCat = "Granos Básicos", estadoCat = true },
                new Categoria { codCat = "C0003", descCat = "Frutas", estadoCat = true }
                );
            context.SaveChanges();
        }
    }
}
