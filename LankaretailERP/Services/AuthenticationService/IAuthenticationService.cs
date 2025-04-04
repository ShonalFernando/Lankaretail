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
        bool Login(string username, string password);
        void Logout();
        bool IsAuthenticated { get; }
        User CurrentUser { get; }
    }
}
