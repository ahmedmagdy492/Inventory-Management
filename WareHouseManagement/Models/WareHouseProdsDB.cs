using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class WareHouseProdsDB
    {
        private WarehouseModel db;

        public WareHouseProdsDB()
        {
            db = new WarehouseModel();
        }

        public Task<List<WareHouseProducts>> GetAll()
        {
            return Task.Run(() =>
            {
                return db.WareHouseProducts.ToList();
            });
        }

        public Task<List<WareHouseProducts>> GetAllIncludeProduct()
        {
            return Task.Run(() =>
            {
                return db.WareHouseProducts.Include("Product").ToList();
            });
        }

        public List<WareHouseProducts> GetProdsWithWarehousesAndDate(int[] warehousesIds, DateTime from, DateTime to)
        {
            var warehouseProds = GetProdsFromSeveralWarehouses(warehousesIds);
            return warehouseProds.Where(wp => wp.Product.ProductionDate >= from && wp.Product.ExpirationDate <= to).ToList();
        }

        public List<WareHouseProducts> GetProdsFromSeveralWarehouses(int[] warehousesIds)
        {
            List<WareHouseProducts> warehouseProds = new List<WareHouseProducts>();
            int counter = 0;
            foreach (var id in warehousesIds)
            {
                foreach (var prod in db.WareHouseProducts.Include("Product").Include("Warehouse").Where(p => p.WareHouseId == id).ToList())
                {
                    warehouseProds.Add(prod);
                }
                counter++;
            }
            return warehouseProds;
        }

        public Task<List<WareHouseProducts>> UpdateOrCreate(WareHouseProducts whp)
        {
            return Task.Run(() =>
            {
                // check if the product is already exist in that warehouse
                var product = db.WareHouseProducts.FirstOrDefault(p => p.ProductId == whp.ProductId && p.WareHouseId == whp.WareHouseId);

                if(product == null)
                {
                    whp.Product = null;
                    whp.Warehouse = null;
                    db.WareHouseProducts.Add(whp);
                }
                else
                {
                    product.Quantity += whp.Quantity;
                }
                db.SaveChanges();
                return GetAll();
            });
        }

        public Task<List<WareHouseProducts>> ReduceProductQuantity(int prodId, int amountOfReduce, int warehouseid)
        {
            return Task.Run(() =>
            {
                var productInWh = db.WareHouseProducts.FirstOrDefault(p => p.ProductId == prodId && p.WareHouseId == warehouseid);
                productInWh.Quantity -= amountOfReduce;
                db.SaveChanges();
                return GetAll();
            });
        }
    }
}
