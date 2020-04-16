using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class DismissalPermissionDB
    {
        private WarehouseModel db;

        public DismissalPermissionDB()
        {
            db = new WarehouseModel();
        }

        public Task<List<DismissalPermission>> GetAll()
        {
            return Task.Run(() =>
            {
                return db.DismissalPermissions.Where(dp => dp.IsDeleted == false).ToList();
            });
        }

        public Task<List<DismissalPermission>> GetWithDate(DateTime from, DateTime to)
        {
            return Task.Run(() =>
            {
                return db.DismissalPermissions.Where(dp => dp.PermissionDate >= from && dp.PermissionDate <= to).ToList();
            });
        }

        public Task<List<DismissalPermission>> GetWithId(int id)
        {
            return Task.Run(() =>
            {
                return db.DismissalPermissions.Where(sp => sp.WareHouseId == id).ToList();
            });
        }

        public Task<DismissalPermission> GetOne(int id)
        {
            return Task.Run(() =>
            {
                var dp = db.DismissalPermissions.FirstOrDefault(d => d.Id == id);
                return dp;
            });
        }

        public Task<DismissalPermission> Create(DismissalPermission dp)
        {
            return Task.Run(() =>
            {
                db.DismissalPermissions.Add(dp);
                db.SaveChanges();
                return dp;
            });
        }

        public Task<List<DismissalPermission>> Delete(int id)
        {
            return Task.Run(() =>
            {
                var dp = db.DismissalPermissions.FirstOrDefault(d => d.Id == id);
                dp.IsDeleted = true;
                db.SaveChanges();
                return GetAll();
            });
        }
    }
}
