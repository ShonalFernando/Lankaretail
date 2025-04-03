using iNKORE.UI.WPF.Modern.Controls;
using LankaretailERP.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.ViewModels
{
    public class AuthenticationViewModel : BindableBase
    {

        public AuthenticationViewModel()
        {
            CurrentView = new SignIn();

            GotoSignInCommand = new DelegateCommand(GotoSignIn);
            GotoSignUpCommand = new DelegateCommand(GotoSignUp);
            SignInCommand = new DelegateCommand(SignIn);
            SignUpCommand = new DelegateCommand(SignUp);
            ExitCommand = new DelegateCommand(Exit);
            //GotoAboutCommand = new DelegateCommand(() => NavigateTo("AboutView"));
            //GotoPrivacyCommand = new DelegateCommand(() => NavigateTo("PrivacyView"));
        }

        // Fields with notifications
        private string _username = "";
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password = "";
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _rePassword = "";
        public string RePassword
        {
            get => _rePassword;
            set => SetProperty(ref _rePassword, value);
        }

        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        // Commands
        public DelegateCommand GotoSignInCommand { get; }
        public DelegateCommand GotoSignUpCommand { get; }
        public DelegateCommand SignInCommand { get; }
        public DelegateCommand SignUpCommand { get; }
        public DelegateCommand ExitCommand { get; }
        public DelegateCommand GotoAboutCommand { get; }
        public DelegateCommand GotoPrivacyCommand { get; }

        // Methods for navigation
        private void GotoSignIn() => CurrentView = new SignIn();
        private void GotoSignUp() => CurrentView = new SignUp();

        // Authentication Logic (Placeholder)
        private void SignIn()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                // Show error message
                return;
            }
            // Perform Sign-in logic
        }

        private void SignUp()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || Password != RePassword)
            {
                // Show error message
                return;
            }
            // Perform Sign-up logic
        }

        private void Exit() => System.Windows.Application.Current.Shutdown();

        // private void NavigateTo(string viewName) => _regionManager.RequestNavigate("ContentRegion", viewName);
    }
}
