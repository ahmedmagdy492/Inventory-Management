namespace WareHouseLib
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WarehouseModel : DbContext
    {

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> WareHouses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DismissalPermission> DismissalPermissions { get; set; }
        public DbSet<SupplyPermission> SupplyPermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplyPermissionProducts> SupplyPermissionProducts { get; set; }
        public DbSet<DismissalPermissionProducts> DismissalPermissionProducts { get; set; }
        public DbSet<WareHouseProducts> WareHouseProducts { get; set; }
        // Your context has been configured to use a 'WarehouseModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WareHouseLib.WarehouseModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WarehouseModel' 
        // connection string in the application configuration file.
        public WarehouseModel()
            : base("name=WarehouseModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}