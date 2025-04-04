using FluentValidation.Results;
using HandyControl.Controls;
using iNKORE.UI.WPF.Modern.Controls;
using LankaretailERP.Services;
using LankaretailERP.Validators;
using LankaretailERP.View.Windows;
using LankaretailERP.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LankaretailERP.ViewModels
{
    public class AuthenticationViewModel : BindableBase, IDataErrorInfo
    {
        private readonly IAuthenticationService _authService;
        private readonly AuthenticationValidator _validator = new();

        public AuthenticationViewModel(IAuthenticationService authService)
        {
            _authService = authService;

            _currentView = new SignIn();

            GotoSignInCommand = new DelegateCommand(GotoSignIn);
            GotoSignUpCommand = new DelegateCommand(GotoSignUp);
            SignInCommand = new DelegateCommand(SignIn,CanSignIn);
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
            set
            {
                SetProperty(ref _username, value);
                SignInCommand.RaiseCanExecuteChanged(); // <-- This updates the button
            }
        }

        private string _password = "";
        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                SignInCommand.RaiseCanExecuteChanged(); // <-- This updates the button
            }
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
        
        public string Error => null;

        public string this[string propertyName]
        {
            get
            {
                ValidationResult result = _validator.Validate(this);
                var error = result.Errors.FirstOrDefault(e => e.PropertyName == propertyName);
                return error?.ErrorMessage;
            }
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
            // Perform Sign-in logic
            if(_authService.Login(Username, Password))
                {
                // Show Shell
                var shell = new ShellWindow(); // Or resolve via container
                shell.Show();

                // Identify and then close current window (Auth)
                Application.Current.Windows
                .OfType<System.Windows.Window>()
                .FirstOrDefault(w => w.DataContext == this)
                ?.Close();
                }
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

        // Preventive Validation -> For Further Security
        private bool CanSignIn()
        {
            var result = _validator.Validate(this);
            return result.IsValid;
        }
    }
}
