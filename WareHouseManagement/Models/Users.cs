using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseLib;

namespace WareHouseManagement.Models
{
    public class Users
    {
        private WarehouseModel db;
        public Users()
        {
            db = new WarehouseModel();
        }

        public Task<User> Login(string username, string passwd)
        {
            return Task.Run(() =>
            {
                return db.Users.FirstOrDefault(u => u.Username == username && u.Password == passwd);
            });
        }

        public Task<List<User>> GetUsers()
        {
            return Task.Run(() =>
            {
                return db.Users.ToList();
            });
        }

        public Task<List<User>> CreateUser(string username, string passwd)
        {
            User user = new User
            {
                Username = username,
                Password = passwd,
                IsDeleted = false
            };
            return Task.Run(() =>
            {
                db.Users.Add(user);
                db.SaveChanges();
                return db.Users.ToList();
            });
        }

        public Task<User> GetUser(int id)
        {
            return Task.Run(() =>
            {
                return db.Users.FirstOrDefault(u => u.Id == id);
            });
        }

        public Task<List<User>> DeleteUser(User user)
        {
            return Task.Run(() =>
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return db.Users.ToList();
            });
        }
    }
}
