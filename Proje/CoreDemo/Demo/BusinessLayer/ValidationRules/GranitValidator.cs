using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GranitValidator : AbstractValidator<Granit>
    {
        public GranitValidator()
        {
            RuleFor(x => x.Granit_Name).NotEmpty().WithMessage("Model ismi boş geçilemez");
            RuleFor(x => x.Granit_Image).NotEmpty().WithMessage("Model resmi boş geçilemez");
        }
    }
}
