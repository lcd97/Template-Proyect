namespace XalliHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Inv.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codCat = c.String(nullable: false, maxLength: 5),
                        descCat = c.String(nullable: false, maxLength: 50),
                        estadoCat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Inv.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codProd = c.String(nullable: false, maxLength: 5),
                        nombProd = c.String(nullable: false, maxLength: 80),
                        precioProd = c.Double(nullable: false),
                        cantProd = c.Int(nullable: false),
                        estadoProd = c.Boolean(nullable: false),
                        unidadMedidaId = c.Int(nullable: false),
                        categoriaId = c.Int(nullable: false),
                        UnidadDeMedida_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Inv.Categorias", t => t.categoriaId)
                .ForeignKey("Inv.UnidadesDeMedida", t => t.UnidadDeMedida_Id)
                .Index(t => t.categoriaId)
                .Index(t => t.UnidadDeMedida_Id);
            
            CreateTable(
                "Inv.DetallesDeEntrada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cantDE = c.Int(nullable: false),
                        precioDE = c.Double(nullable: false),
                        entradaId = c.Int(nullable: false),
                        productoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Inv.Entradas", t => t.entradaId)
                .ForeignKey("Inv.Productos", t => t.productoId)
                .Index(t => t.entradaId)
                .Index(t => t.productoId);
            
            CreateTable(
                "Inv.Entradas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codEnt = c.String(nullable: false, maxLength: 5),
                        fechaEnt = c.DateTime(nullable: false),
                        estadoEnt = c.Boolean(nullable: false),
                        proveedorId = c.Int(nullable: false),
                        tipoEntradaId = c.Int(nullable: false),
                        TipoDeEntrada_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Inv.Proveedores", t => t.proveedorId)
                .ForeignKey("Inv.TiposDeEntrada", t => t.TipoDeEntrada_Id)
                .Index(t => t.proveedorId)
                .Index(t => t.TipoDeEntrada_Id);
            
            CreateTable(
                "Inv.Proveedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codProv = c.String(nullable: false, maxLength: 5),
                        RUC = c.Int(nullable: false),
                        nombComercial = c.String(maxLength: 80),
                        telProv = c.String(nullable: false, maxLength: 12),
                        nomProv = c.String(maxLength: 50),
                        apeProv = c.String(maxLength: 50),
                        cedProv = c.String(maxLength: 16),
                        estadoProv = c.Boolean(nullable: false),
                        Retencion = c.Boolean(nullable: false),
                        LocalProv = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Inv.TiposDeEntrada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codTE = c.String(nullable: false, maxLength: 5),
                        descTE = c.String(nullable: false, maxLength: 50),
                        estadoTE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Inv.UnidadesDeMedida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codUM = c.String(nullable: false, maxLength: 5),
                        descUM = c.String(nullable: false, maxLength: 50),
                        cantUM = c.Int(nullable: false),
                        cantUnidad = c.Int(nullable: false),
                        presentacion = c.String(nullable: false, maxLength: 50),
                        estadoUM = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Inv.Productos", "UnidadDeMedida_Id", "Inv.UnidadesDeMedida");
            DropForeignKey("Inv.DetallesDeEntrada", "productoId", "Inv.Productos");
            DropForeignKey("Inv.Entradas", "TipoDeEntrada_Id", "Inv.TiposDeEntrada");
            DropForeignKey("Inv.Entradas", "proveedorId", "Inv.Proveedores");
            DropForeignKey("Inv.DetallesDeEntrada", "entradaId", "Inv.Entradas");
            DropForeignKey("Inv.Productos", "categoriaId", "Inv.Categorias");
            DropIndex("Inv.Entradas", new[] { "TipoDeEntrada_Id" });
            DropIndex("Inv.Entradas", new[] { "proveedorId" });
            DropIndex("Inv.DetallesDeEntrada", new[] { "productoId" });
            DropIndex("Inv.DetallesDeEntrada", new[] { "entradaId" });
            DropIndex("Inv.Productos", new[] { "UnidadDeMedida_Id" });
            DropIndex("Inv.Productos", new[] { "categoriaId" });
            DropTable("Inv.UnidadesDeMedida");
            DropTable("Inv.TiposDeEntrada");
            DropTable("Inv.Proveedores");
            DropTable("Inv.Entradas");
            DropTable("Inv.DetallesDeEntrada");
            DropTable("Inv.Productos");
            DropTable("Inv.Categorias");
        }
    }
}
