using FluentValidation;
using StarterKit.Blazor.WebAssembly.Shared.Models;

namespace StarterKit.Blazor.WebAssembly.Client.Validators
{
    public class RegisterParametersValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterParametersValidator() 
        {
            RuleFor(rp => rp.UserName)
                .NotEmpty().WithMessage("User Name is required.")
                .Length(5, 30);
            RuleFor(rp => rp.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6);
            RuleFor(rp => rp.PasswordConfirm)
                .NotEmpty().WithMessage("Password Confirmation is required.")
                .Equal(rp => rp.Password).WithMessage("Password values should be equal.");
        }
    }
}
