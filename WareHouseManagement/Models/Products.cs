using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class Products
    {
        private WarehouseModel db;

        public Products()
        {
            db = new WarehouseModel();
        }

        public Task<List<Product>> GetProducts()
        {
            return Task.Run(() =>
            {
                return db.Products.Where(p => p.IsDeleted == false).ToList();
            });
        }

        public Task<List<Product>> GetProductsWithCount(int count)
        {
            return Task.Run(() =>
            {
                List<Product> prods = new List<Product>();
                for(int i = db.Products.Count() - 1; i >= count; i--)
                {
                    prods.Add(db.Products.ToList()[i]);
                }
                return prods;
            });
        }

        public Task<List<WareHouseProducts>> GetProductsOfWarehouse(int wid)
        {
            return Task.Run(() =>
            {
                return db.WareHouseProducts.Include("Product").Include("Warehouse").Where(wp => wp.WareHouseId == wid).ToList();
            });
        }       

        public Task<Product> CreateOrNo(Product product, int warehouseid)
        {
            return Task.Run(() =>
            {
                // checking if product is already exist or not
                var prod = db.Products.FirstOrDefault(p => p.Name == product.Name);
                
                if(prod == null)
                {
                    //var wprod = db.WareHouseProducts.FirstOrDefault(wp => wp.ProductId == prod.Id && wp.WareHouseId == warehouseid);
                    db.Products.Add(product);
                    db.SaveChanges();
                    product = db.Products.FirstOrDefault(p => p.Name == product.Name);
                }                                
                return prod ?? product;
            });
        }

        public Task<List<Product>> DeleteProduct(int id)
        {
            return Task.Run(() =>
            {
                var product = db.Products.FirstOrDefault(p => p.Id == id);
                product.IsDeleted = true;
                db.SaveChanges();
                return GetProducts();
            });
        }

    }
}
