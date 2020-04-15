namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeCustomerIdNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DismissalPermissionProducts", new[] { "CustomerId" });
            AlterColumn("dbo.DismissalPermissionProducts", "CustomerId", c => c.Int());
            CreateIndex("dbo.DismissalPermissionProducts", "CustomerId");
            AddForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DismissalPermissionProducts", new[] { "CustomerId" });
            AlterColumn("dbo.DismissalPermissionProducts", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.DismissalPermissionProducts", "CustomerId");
            AddForeignKey("dbo.DismissalPermissionProducts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
