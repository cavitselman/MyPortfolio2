using DenemeCore.EL.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeCore.BL.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Başlık alanı boş geçilemez!");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih alanı boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel URL alanı boş geçilemez!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez!");
        }
    }
}
