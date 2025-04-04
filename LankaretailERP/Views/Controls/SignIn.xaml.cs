using HandyControl.Controls;
using LankaretailERP.Services.AuthenticationService;
using LankaretailERP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LankaretailERP.Views.Controls
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
            InitializeUserInterfaces();
        }

        private void InitializeUserInterfaces()
        {
            SignIn_Outputs_PaswordError.Text = "Please Enter a Password";
        }

        private void UserChangesPassword(object sender, RoutedEventArgs e)
        {
            if (DataContext is AuthenticationViewModel vm)
            {
                vm.Password = SignIn_Inputs_PasswordBox.Password;

                // Ask ViewModel for error (if using IDataErrorInfo or FluentValidation)
                var error = vm[nameof(vm.Password)];

                SignIn_Outputs_PaswordError.Text = string.IsNullOrWhiteSpace(error) ? "" : error;
            }
        }
    }
}
