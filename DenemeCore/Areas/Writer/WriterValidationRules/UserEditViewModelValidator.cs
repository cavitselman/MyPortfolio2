using DenemeCore.Areas.Writer.Models;
using FluentValidation;

namespace DenemeCore.Areas.Writer.WriterValidationRules
{
    public class UserEditViewModelValidator:AbstractValidator<UserEditViewModel>
    {
        public UserEditViewModelValidator() 
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
