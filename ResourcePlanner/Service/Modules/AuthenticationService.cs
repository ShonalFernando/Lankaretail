using LankaRetail.Data;
using LankaRetail.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePlanner.Service.Modules
{
    public class UserService
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public UserService()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlite("Data Source=erp.db");
            _options = builder.Options;
        }

        // ✅ Add new user
        public void AddUser(string username, string password, int roleId)
        {
            using var db = new AppDbContext(_options);

            var user = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                RoleId = roleId
            };

            db.Users.Add(user);
            db.SaveChanges();
        }

        // ✅ Update existing user
        public void UpdateUser(int userId, string newUsername, string newPassword, int newRoleId)
        {
            using var db = new AppDbContext(_options);

            var user = db.Users.Find(userId);
            if (user != null)
            {
                user.Username = newUsername;
                user.PasswordHash = HashPassword(newPassword);
                user.RoleId = newRoleId;

                db.Users.Update(user);
                db.SaveChanges();
            }
        }

        // ✅ Delete a user
        public void DeleteUser(int userId)
        {
            using var db = new AppDbContext(_options);

            var user = db.Users.Find(userId);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        // ✅ Get all users
        public List<User> GetAllUsers()
        {
            using var db = new AppDbContext(_options);
            return db.Users.Include(u => u.Role).ToList();
        }

        // ✅ Authenticate user
        public User Authenticate(string username, string password)
        {
            using var db = new AppDbContext(_options);

            string hashed = HashPassword(password);
            return db.Users.Include(u => u.Role)
                           .FirstOrDefault(u => u.Username == username && u.PasswordHash == hashed);
        }

        // 🔒 Simple hash (base64 — not secure, but okay for learning)
        private string HashPassword(string plainText)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainText);
        }
    }
}
