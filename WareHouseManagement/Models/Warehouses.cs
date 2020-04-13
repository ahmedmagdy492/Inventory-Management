using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class Warehouses
    {
        private WarehouseModel db;

        public Warehouses()
        {
            db = new WarehouseModel();
        }

        public Task<List<Warehouse>> GetWarehouses()
        {
            return Task.Run(() =>
            {
                return db.WareHouses.Where(w => w.IsDeleted == false).ToList();
            });
        }

        public Task<Warehouse> GetOne(int id)
        {
            return Task.Run(() =>
            {
                return db.WareHouses.FirstOrDefault(w => w.Id == id);
            });
        }

        public Task<List<Warehouse>> CreateWareHouse(Warehouse warehouse)
        {
            return Task.Run(() =>
            {
                db.WareHouses.Add(warehouse);
                db.SaveChanges();
                return GetWarehouses();
            });
        }

        public Task<List<Warehouse>> DeleteWareHouse(int id)
        {
            return Task.Run(() =>
            {
                var warehouse = db.WareHouses.FirstOrDefault(w => w.Id == id);
                warehouse.IsDeleted = true;
                //db.WareHouses.Remove(warehouse);
                db.SaveChanges();
                return GetWarehouses();
            });
        }

        public Task<List<Warehouse>> ModifyWarehouse(Warehouse newData, int oldId)
        {
            return Task.Run(() =>
            {
                var warehouse = db.WareHouses.FirstOrDefault(w => w.Id == oldId);
                warehouse.Name = newData.Name;
                warehouse.Address = newData.Address;
                warehouse.StoreKeeper = newData.StoreKeeper;
                db.SaveChanges();
                return GetWarehouses();
            });
        }
    }
}
