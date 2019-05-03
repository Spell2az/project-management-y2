namespace ClientEshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeInfo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.AspNetUsers", newName: "ApplicationUser");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.ApplicationUser", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            CreateTable(
                "dbo.EmployeeInfo",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Receive = c.Boolean(nullable: false),
                        Stow = c.Boolean(nullable: false),
                        Pick = c.Boolean(nullable: false),
                        Pack = c.Boolean(nullable: false),
                        Ship = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.AspNetUserRoles", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUserClaims", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUserLogins", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.ApplicationUser", "Email", c => c.String());
            AlterColumn("dbo.ApplicationUser", "UserName", c => c.String());
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String());
            CreateIndex("dbo.AspNetUserClaims", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserLogins", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserRoles", "ApplicationUser_Id");
            AddForeignKey("dbo.AspNetUserClaims", "ApplicationUser_Id", "dbo.ApplicationUser", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "ApplicationUser_Id", "dbo.ApplicationUser", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "ApplicationUser_Id", "dbo.ApplicationUser", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.AspNetUserLogins", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.AspNetUserClaims", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.EmployeeInfo", "Id", "dbo.ApplicationUser");
            DropIndex("dbo.AspNetUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.EmployeeInfo", new[] { "Id" });
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ApplicationUser", "UserName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ApplicationUser", "Email", c => c.String(maxLength: 256));
            DropColumn("dbo.AspNetUserLogins", "ApplicationUser_Id");
            DropColumn("dbo.AspNetUserClaims", "ApplicationUser_Id");
            DropColumn("dbo.AspNetUserRoles", "ApplicationUser_Id");
            DropTable("dbo.EmployeeInfo");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.ApplicationUser", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.ApplicationUser", newName: "AspNetUsers");
            RenameTable(name: "dbo.Product", newName: "Products");
        }
    }
}
