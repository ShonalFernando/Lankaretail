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
            return Container.Resolve<MainWindow>(); // Resolve the main window
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register dependencies here
        }
    }

}
