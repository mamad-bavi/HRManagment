using Application.DTOs.Location.CityDtos.CommandDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.FluentValidation.Location.City
{
    public class CityCreateDtoValidation : AbstractValidator<CityCreateDto>
    {
        public CityCreateDtoValidation()
        {

            RuleFor(c => c.Name)
                .MaximumLength(100)
                .WithMessage("{Property} نباید بیش از 100 کاراکتر باشد");
        }
    }
}
