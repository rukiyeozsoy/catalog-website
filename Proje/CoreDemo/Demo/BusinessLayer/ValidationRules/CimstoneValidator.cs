using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CimstoneValidator : AbstractValidator<Cimstone>
    {
        public CimstoneValidator()
        {
            RuleFor(x => x.Cimstone_Name).NotEmpty().WithMessage("Model ismi boş geçilemez");
            RuleFor(x => x.Cimstone_Image).NotEmpty().WithMessage("Model resmi boş geçilemez");
        }
    }
}
