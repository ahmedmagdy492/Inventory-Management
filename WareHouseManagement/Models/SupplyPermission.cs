using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class SupplyPermissions
    {
        private WarehouseModel db;

        public SupplyPermissions()
        {
            db = new WarehouseModel();
        }
        public Task<List<SupplyPermission>> GetAll()
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissions.Where(sp => sp.IsDeleted == false).ToList();
            });
        }

        public Task<List<SupplyPermission>> GetWithDate(DateTime from, DateTime to)
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissions.Where(sp => sp.PermissionDate >= from && sp.PermissionDate <= to).ToList();
            });
        }

        public Task<List<SupplyPermission>> GetWithId(int id)
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissions.Where(sp => sp.WareHouseId == id).ToList();
            });
        }

        public Task<List<SupplyPermissionProducts>> GetAllWithId(int id)
        {
            return Task.Run(() =>
            {
                return db.SupplyPermissionProducts.Include("Product").Include("SupplyPermission").Where(sp => sp.SupplyPerId == id).ToList();
            });
        }        

        public Task<SupplyPermission> Create(SupplyPermission spermission)
        {
            return Task.Run(() =>
            {
                var sp = db.SupplyPermissions.Add(spermission);
                db.SaveChanges();
                return sp;
            });
        }

        public Task<List<SupplyPermission>> Delete(int id)
        {
            return Task.Run(() =>
            {
                var sp = db.SupplyPermissions.FirstOrDefault(s => s.Id == id);
                sp.IsDeleted = true;
                db.SaveChanges();
                return GetAll();
            });
        }
    }
}
