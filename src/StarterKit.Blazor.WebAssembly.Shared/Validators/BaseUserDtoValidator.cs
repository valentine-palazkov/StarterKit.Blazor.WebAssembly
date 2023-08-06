using FluentValidation;
using StarterKit.Blazor.WebAssembly.Shared.Models;

namespace StarterKit.Blazor.WebAssembly.Shared.Validators
{
    public class BaseUserDtoValidator<TUserDto> : AbstractValidator<TUserDto> where TUserDto : BaseUserDto
    {
        public BaseUserDtoValidator()
        {
            RuleFor(bp => bp.UserName).NotEmpty().WithMessage("User Name is required.")
                .Length(5, 30);
            RuleFor(bp => bp.Password)
               .NotEmpty().WithMessage("Password is required.")
               .MinimumLength(6);
        }
    }
}
