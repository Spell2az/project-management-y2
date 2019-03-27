namespace ManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeInfoAndName : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Users");
            CreateTable(
                "dbo.EmployeeInfos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Receive = c.Boolean(nullable: false),
                        Stow = c.Boolean(nullable: false),
                        Pick = c.Boolean(nullable: false),
                        Pack = c.Boolean(nullable: false),
                        Ship = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(nullable: false, maxLength: 120, unicode: false),
                        Role = c.String(),
                        HashedPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.Byte(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeInfos", "Id", "dbo.Users");
            DropIndex("dbo.EmployeeInfos", new[] { "Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Users");
            DropTable("dbo.EmployeeInfos");
        }
    }
}
