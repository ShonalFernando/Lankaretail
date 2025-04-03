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

            containerRegistry.RegisterForNavigation<AuthenticationView, AuthenticationViewModel>();


        }
    }

}
