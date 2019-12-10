namespace ExamenWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ContactoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DocumentoIdentidad = c.String(),
                        FechaCreacion = c.String(),
                    })
                .PrimaryKey(t => t.ContactoID);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        VisitaID = c.Int(nullable: false, identity: true),
                        Motivo = c.Int(nullable: false),
                        FechaVisita = c.String(),
                        HoraEntrada = c.String(),
                        HoraSalida = c.String(),
                        NombreCompleto = c.String(),
                        ContactoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaID)
                .ForeignKey("dbo.Contactoes", t => t.ContactoID)
                .Index(t => t.ContactoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitas", "ContactoID", "dbo.Contactoes");
            DropIndex("dbo.Visitas", new[] { "ContactoID" });
            DropTable("dbo.Visitas");
            DropTable("dbo.Contactoes");
        }
    }
}
