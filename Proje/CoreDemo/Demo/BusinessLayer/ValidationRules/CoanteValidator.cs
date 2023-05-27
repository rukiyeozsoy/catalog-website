using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CoanteValidator : AbstractValidator<Coante>
    {
        public CoanteValidator()
        {
            RuleFor(x => x.Coante_Name).NotEmpty().WithMessage("Model ismi boş geçilemez");
            RuleFor(x => x.Coante_Image).NotEmpty().WithMessage("Model resmi boş geçilemez");
        }
    }
}
