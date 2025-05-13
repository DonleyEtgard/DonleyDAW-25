namespace Tienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerMigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetalleFacturas", "NumeroFactura", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetalleFacturas", "NumeroFactura");
        }
    }
}
