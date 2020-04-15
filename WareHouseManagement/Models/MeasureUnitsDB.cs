using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    class MeasureUnitsDB
    {
        private WarehouseModel db;
        public MeasureUnitsDB()
        {
            db = new WarehouseModel();
        }
        public Task<List<ProductMeasureUnit>> GetAll()
        {
            return Task.Run(() =>
            {
                return db.ProductMeasureUnits.ToList();
            });
        }
    }
}
