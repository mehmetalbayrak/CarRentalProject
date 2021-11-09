using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Araba açıklaması boş olamaz.");
            RuleFor(x => x.DailyPrice).NotEmpty().WithMessage("Fiyat boş olamaz.");
            RuleFor(x => x.ModelYear).NotEmpty().WithMessage("Model yılı boş olamaz.");
        }
    }
}
