using Core_Proje.Areas.Writer.Models;
using FluentValidation;

namespace Core_Proje.Areas.Writer.WriterValidationRules
{
    public class UserPasswordEditViewModelValidator : AbstractValidator<UserPasswordEditViewModel>
    {
        public UserPasswordEditViewModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("En az 6 karakter girmelisiniz!");
            RuleFor(x => x.Password).MaximumLength(12).WithMessage("En fazla 12 karakter girebilirsiniz!");
        }
    }
}
