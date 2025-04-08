using HandyControl.Controls;
using LankaretailERP.Data.DataRepository;
using LankaretailERP.Data.SQLite;
using LankaretailERP.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LankaretailERP.Services.AuthenticationService
{
    class AuthenticationService : IAuthenticationService
    {
        private User? _currentUser;
        private readonly IDataRepository<User> _userRepo;

        public AuthenticationService(SqliteUserRepository userRepo)
        {
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
        }

        public async Task<(bool, string)> Login(string username, string password)
        {
            // Fetch all users from the repository
            var allUsers = await _userRepo.GetAllAsync() as List<User>;

            // Return false if no users are found
            if (allUsers == null)
            {
                return (false, "No Users Found");
            }

            // Find the user by username
            var user = allUsers.FirstOrDefault(x => x.Username == username);

            // If the user does not exist or password doesn't match, return false
            if (user != null && user.PasswordHash == password)
            {
                return (false, "");
            }
            else
            {
                if (user == null)
                {
                    return (false, "No User Found");
                }
                else
                {
                    return (false, "Password is incorrect");
                }
            }
        }


        public void Logout()
        {
            // Destroy THe Session
            _currentUser = null;
        }

        public async Task<bool> SignUpAsync(string username, string password)
        {
            var user = new User
            {
                Role = "Admin",
                CreatedAt = DateTime.Now,
                Email = "Test@test.com",
                FullName = "Admin",
                IsActive = true,
                LastLogin = DateTime.Now,
                PasswordHash = "ABC", // You should hash the password properly
                UserID = 1,  // You probably want to remove this or auto-generate
                Username = "Admin"
            };

            // Assuming AddAsync returns void or Task, you might want to check success here
            await _userRepo.AddAsync(user);

            // If AddAsync was successful, you can return true
            return true;
        }

        public bool IsAuthenticated => !(_currentUser is null);

        public User CurrentUser => _currentUser is null ? new User() : _currentUser;
    }
}
