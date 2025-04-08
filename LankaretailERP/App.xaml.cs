using LankaretailERP.Services.AuthenticationService;
using LankaretailERP.Services;
using LankaretailERP.View;
using LankaretailERP.View.Windows;
using LankaretailERP.ViewModel;
using LankaretailERP.ViewModels;
using LankaretailERP.Views;
using LankaretailERP.Views.Controls;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using LankaretailERP.Model;
using LankaretailERP.Data.SQLite;
using LankaretailERP.Data.DataRepository;

namespace LankaretailERP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<AuthenticationView>(); // Resolve the main window
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register dependencies here
            containerRegistry.RegisterForNavigation<SignIn>();
            containerRegistry.RegisterForNavigation<SignUp>();
            containerRegistry.RegisterSingleton<IRegionManager, RegionManager>();

            // DBContext : SQLite
            var options = new DbContextOptionsBuilder<SqliteDbContext>()
                .UseSqlite("Data Source=appdata.db")
                .Options;

            var dbContext = new SqliteDbContext(options);
            dbContext.Database.EnsureCreated();

            containerRegistry.RegisterInstance(dbContext);
            containerRegistry.Register<IDataRepository<User>, SqliteUserRepository>();

            // Navigation Registration
            containerRegistry.RegisterForNavigation<AuthenticationView, AuthenticationViewModel>();

            // Other Services
            containerRegistry.RegisterSingleton<IAuthenticationService, AuthenticationService>();

        }
    }

}
