namespace ExamenWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregacionCampoApellidoContacto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Apellido", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contactoes", "Apellido");
        }
    }
}
