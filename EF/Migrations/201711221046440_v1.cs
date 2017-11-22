namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(storeType: "ntext"),
                        DateOfBirth = c.DateTime(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Standard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Standards", t => t.Standard_Id)
                .Index(t => t.Standard_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Standard_Id", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "Standard_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Standards");
        }
    }
}
