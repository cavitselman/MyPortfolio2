using DenemeCore.Areas.Writer.Models;
using FluentValidation;

namespace DenemeCore.Areas.Writer.WriterValidationRules
{
    public class UserEditViewModelValidator :AbstractValidator<UserEditViewModel>
    {
        public UserEditViewModelValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş geçilemez!");
        }
    }
}
