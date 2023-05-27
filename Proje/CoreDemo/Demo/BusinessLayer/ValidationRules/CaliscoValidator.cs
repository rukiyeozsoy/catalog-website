using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CaliscoValidator:AbstractValidator<Calisco>
    {
        public CaliscoValidator()
        {
            RuleFor(x => x.Calisco_Name).NotEmpty().WithMessage("Model ismi boş geçilemez");
            RuleFor(x => x.Calisco_Image).NotEmpty().WithMessage("Model resmi boş geçilemez");
        }
    }
}
