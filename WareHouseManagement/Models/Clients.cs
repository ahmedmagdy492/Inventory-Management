using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class Clients
    {
        private WarehouseModel db;

        public Clients()
        {
            db = new WarehouseModel();
        }

        public Task<List<Customer>> GetCustomers()
        {
            return Task.Run(() =>
            {
                return db.Customers.Where(c => c.IsDeleted == false).ToList();
            });
        }

        public Task<List<Customer>> CreateCustomer(Customer customer)
        {
            return Task.Run(() =>
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return GetCustomers();
            });
        }

        public Task<List<Customer>> DeleteCustomer(int id)
        {
            return Task.Run(() =>
            {
                var customer = db.Customers.FirstOrDefault(c => c.Id == id);
                customer.IsDeleted = true;
                db.SaveChanges();
                return GetCustomers();
            });
        }        

        public Task<List<Customer>> EditCustomer(Customer customer, int oldid)
        {
            return Task.Run(() =>
            {
                var cust = db.Customers.FirstOrDefault(c => c.Id == oldid);
                cust.Name = customer.Name;
                cust.MobilePhone = customer.MobilePhone;
                cust.Telephone = customer.Telephone;
                cust.Fax = customer.Fax;
                cust.Email = customer.Email;
                cust.Website = customer.Website;
                db.SaveChanges();
                return GetCustomers();
            });
        }
    }
}
