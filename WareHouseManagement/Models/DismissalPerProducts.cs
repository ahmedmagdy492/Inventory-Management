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
