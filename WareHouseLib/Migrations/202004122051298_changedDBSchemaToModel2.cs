namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDBSchemaToModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DismissalPermissions", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplyPermissions", "ProductId", "dbo.Products");
            DropIndex("dbo.DismissalPermissions", new[] { "ProductId" });
            DropIndex("dbo.SupplyPermissions", new[] { "ProductId" });
            RenameColumn(table: "dbo.SupplyPermissions", name: "ProductId", newName: "Product_Id");
            CreateTable(
                "dbo.DismissalPermissionProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        DismissalPerId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.DismissalPerId })
                .ForeignKey("dbo.DismissalPermissions", t => t.DismissalPerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.DismissalPerId);
            
            CreateTable(
                "dbo.SupplyPermissionProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        SupplyPerId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.SupplyPerId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.SupplyPermissions", t => t.SupplyPerId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplyPerId);
            
            CreateTable(
                "dbo.WareHouseProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        WareHouseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.WareHouseId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WareHouseId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.WareHouseId);
            
            AlterColumn("dbo.SupplyPermissions", "Product_Id", c => c.Int());
            CreateIndex("dbo.SupplyPermissions", "Product_Id");
            AddForeignKey("dbo.SupplyPermissions", "Product_Id", "dbo.Products", "Id");
            DropColumn("dbo.DismissalPermissions", "Quantity");
            DropColumn("dbo.DismissalPermissions", "ProductId");
            DropColumn("dbo.SupplyPermissions", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplyPermissions", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.DismissalPermissions", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.DismissalPermissions", "Quantity", c => c.Int(nullable: false));
            DropForeignKey("dbo.SupplyPermissions", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DismissalPermissionProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.WareHouseProducts", "WareHouseId", "dbo.Warehouses");
            DropForeignKey("dbo.WareHouseProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplyPermissionProducts", "SupplyPerId", "dbo.SupplyPermissions");
            DropForeignKey("dbo.SupplyPermissionProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DismissalPermissionProducts", "DismissalPerId", "dbo.DismissalPermissions");
            DropIndex("dbo.WareHouseProducts", new[] { "WareHouseId" });
            DropIndex("dbo.WareHouseProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplyPermissionProducts", new[] { "SupplyPerId" });
            DropIndex("dbo.SupplyPermissionProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplyPermissions", new[] { "Product_Id" });
            DropIndex("dbo.DismissalPermissionProducts", new[] { "DismissalPerId" });
            DropIndex("dbo.DismissalPermissionProducts", new[] { "ProductId" });
            AlterColumn("dbo.SupplyPermissions", "Product_Id", c => c.Int(nullable: false));
            DropTable("dbo.WareHouseProducts");
            DropTable("dbo.SupplyPermissionProducts");
            DropTable("dbo.DismissalPermissionProducts");
            RenameColumn(table: "dbo.SupplyPermissions", name: "Product_Id", newName: "ProductId");
            CreateIndex("dbo.SupplyPermissions", "ProductId");
            CreateIndex("dbo.DismissalPermissions", "ProductId");
            AddForeignKey("dbo.SupplyPermissions", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DismissalPermissions", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
