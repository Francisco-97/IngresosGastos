namespace IngresosGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IngresosGastosFASSes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 60),
                        EsIngresos = c.Boolean(nullable: false),
                        valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.IngresoGastosJCs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IngresoGastosJCs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 60),
                        EsIngreso = c.Boolean(nullable: false),
                        Valor = c.Double(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.IngresosGastosFASSes");
        }
    }
}
