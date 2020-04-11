using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class Providers
    {
        private WarehouseModel db;

        public Providers()
        {
            db = new WarehouseModel();
        }

        public Task<List<Provider>> GetProviders()
        {
            return Task.Run(() =>
            {
                return db.Providers.Where(p => p.IsDeleted == false).ToList();
            });
        }

        public Task<Provider> GetProvider(int id)
        {
            return Task.Run(() =>
            {
                return db.Providers.FirstOrDefault(p => p.Id == id);
            });
        }

        public Task<List<Provider>> CreateProvider(Provider provider)
        {
            return Task.Run(() =>
            {
                db.Providers.Add(provider);
                db.SaveChanges();
                return GetProviders();
            });
        }

        public Task<List<Provider>> DeleteProvider(int id)
        {
            return Task.Run(() =>
            {
                var provider = db.Providers.FirstOrDefault(p => p.Id == id);
                provider.IsDeleted = true;
                db.SaveChanges();
                return GetProviders();
            });
        }

        public Task<List<Provider>> EditProvider(Provider provider, int oldid)
        {
            return Task.Run(() =>
            {
                var oldProvider = db.Providers.FirstOrDefault(p => p.Id == oldid);
                oldProvider.Name = provider.Name;
                oldProvider.MobilePhone = provider.MobilePhone;
                oldProvider.Telephone = provider.Telephone;
                oldProvider.Email = provider.Email;
                oldProvider.Fax = provider.Fax;
                oldProvider.Website = provider.Website;
                db.SaveChanges();
                return GetProviders();
            });
        }
    }
}
