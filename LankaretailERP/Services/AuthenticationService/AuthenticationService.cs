using LankaretailERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Services.AuthenticationService
{
    class AuthenticationService : IAuthenticationService
    {
        private User? _currentUser;

        public bool Login(string username, string password)
        {
            // Dummy logic
            if (username == "admin" && password == "pass123")
            {
                _currentUser = new User { Username = username };
                return true;
            }

            return false;
        }

        public void Logout()
        {
            // Destroy THe Session
            _currentUser = null;
        }

        public bool IsAuthenticated => !(_currentUser is null);

        public User CurrentUser => _currentUser is null ? new User() : _currentUser;
    }
}
