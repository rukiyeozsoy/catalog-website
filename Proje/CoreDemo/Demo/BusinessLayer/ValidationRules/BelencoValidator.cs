using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BelencoValidator:AbstractValidator<Belenco>
    {
        public BelencoValidator()
        {
            RuleFor(x => x.Belenco_Name).NotEmpty().WithMessage("Model ismi boş geçilemez");
            RuleFor(x => x.Belenco_Image).NotEmpty().WithMessage("Model resmi boş geçilemez");
        }
    }
}
