namespace INFRAESTRUCTURE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                        CreatedON = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            AddColumn("dbo.Productoes", "IsEnable", c => c.Boolean(nullable: false));
            DropColumn("dbo.Productoes", "estaActivo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "estaActivo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Productoes", "IsEnable");
            DropTable("dbo.People");
        }
    }
}
