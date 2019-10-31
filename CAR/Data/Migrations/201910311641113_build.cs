namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class build : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.data",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        Color = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        TCCRating = c.Double(nullable: false),
                        HwyMPG = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.data");
        }
    }
}
