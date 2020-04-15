namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMeasureUnitModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductMeasureUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeasureUnitName = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductMeasureUnits", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductMeasureUnits", new[] { "ProductId" });
            DropTable("dbo.ProductMeasureUnits");
        }
    }
}
