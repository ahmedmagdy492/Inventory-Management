using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class DismissalPerProducts
    {
        private WarehouseModel db;
        public DismissalPerProducts()
        {
            db = new WarehouseModel();
        }

        public Task<List<DismissalPermissionProducts>> GetWithId(int id)
        {
            return Task.Run(() =>
            {
                return db.DismissalPermissionProducts.Include("DismissalPermission").Where(dp => dp.DismissalPermission.WareHouseId == id).ToList();
            });
        }

        public Task<List<DismissalPermissionProducts>> GetWithPerId(int perId)
        {
            return Task.Run(() =>
            {
                return db.DismissalPermissionProducts.Include("Product").Where(dpp => dpp.DismissalPerId == perId).ToList();
            });
        }

        public Task Create(DismissalPermissionProducts dpp)
        {
            return Task.Run(() =>
            {
                db.DismissalPermissionProducts.Add(dpp);
                db.SaveChanges();
            });
        }
    }
}
