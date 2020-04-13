namespace WareHouseLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedQuantityToWareHouseProductsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouseProducts", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WareHouseProducts", "Quantity");
        }
    }
}
