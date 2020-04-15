namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movedCustomerIdToMToMTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DismissalPermissions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DismissalPermissions", new[] { "CustomerId" });
            RenameColumn(table: "dbo.DismissalPermissions", name: "CustomerId", newName: "Customer_Id");
            AddColumn("dbo.DismissalPermissionProducts", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.DismissalPermissions", "Customer_Id", c => c.Int());
            CreateIndex("dbo.DismissalPermissions", "Customer_Id");
            CreateIndex("dbo.DismissalPermissionProducts", "CustomerId");
            AddForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DismissalPermissions", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DismissalPermissions", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DismissalPermissionProducts", new[] { "CustomerId" });
            DropIndex("dbo.DismissalPermissions", new[] { "Customer_Id" });
            AlterColumn("dbo.DismissalPermissions", "Customer_Id", c => c.Int(nullable: false));
            DropColumn("dbo.DismissalPermissionProducts", "CustomerId");
            RenameColumn(table: "dbo.DismissalPermissions", name: "Customer_Id", newName: "CustomerId");
            CreateIndex("dbo.DismissalPermissions", "CustomerId");
            AddForeignKey("dbo.DismissalPermissions", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
