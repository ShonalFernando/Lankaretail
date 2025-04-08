using LankaretailERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Services
{
    public interface IAuthenticationService
    {
        Task<(bool,string)> Login(string username, string password);
        void Logout();
        Task<bool> SignUpAsync(string username, string password);
        bool IsAuthenticated { get; }
        User CurrentUser { get; }
    }
}
