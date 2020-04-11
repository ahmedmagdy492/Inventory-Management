namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DismissalPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PermissionDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        WareHouseId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WareHouseId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.WareHouseId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MeasureUnit = c.String(),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        ProviderId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplyPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PermissionDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        WareHouseId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WareHouseId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.WareHouseId);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        StoreKeeper = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DismissalPermissions", "WareHouseId", "dbo.Warehouses");
            DropForeignKey("dbo.DismissalPermissions", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplyPermissions", "WareHouseId", "dbo.Warehouses");
            DropForeignKey("dbo.SupplyPermissions", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.DismissalPermissions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.SupplyPermissions", new[] { "WareHouseId" });
            DropIndex("dbo.SupplyPermissions", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProviderId" });
            DropIndex("dbo.DismissalPermissions", new[] { "CustomerId" });
            DropIndex("dbo.DismissalPermissions", new[] { "WareHouseId" });
            DropIndex("dbo.DismissalPermissions", new[] { "ProductId" });
            DropTable("dbo.Warehouses");
            DropTable("dbo.SupplyPermissions");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.DismissalPermissions");
            DropTable("dbo.Customers");
        }
    }
}
