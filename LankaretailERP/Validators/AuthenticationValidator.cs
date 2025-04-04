using FluentValidation;
using LankaretailERP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaretailERP.Validators
{
    internal class AuthenticationValidator : AbstractValidator<AuthenticationViewModel>
    {
        public AuthenticationValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required.")
                .Matches("^[a-zA-Z0-9]+$").WithMessage("Username must be alphanumeric.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
        }
    }
}
