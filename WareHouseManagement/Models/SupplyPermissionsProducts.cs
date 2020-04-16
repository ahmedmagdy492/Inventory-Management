using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class SupplyPermissionsProductsDB
    {
        private WarehouseModel db;

        public SupplyPermissionsProductsDB()
        {
            db = new WarehouseModel();
        }

        public Task<List<SupplyPermissionProducts>> GetWithId(int perId)
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissionProducts.Include("Product").Where(spp => spp.SupplyPerId == perId).ToList();
            });
        }

        public Task<List<SupplyPermissionProducts>> GetAll()
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissionProducts.ToList();
            });
        }

        public Task<List<SupplyPermissionProducts>> Create(SupplyPermissionProducts spp)
        {
            return Task.Run(() =>
            {
                db.SupplyPermissionProducts.Add(spp);
                db.SaveChanges();
                return GetAll();
            });
        }
    }
}
