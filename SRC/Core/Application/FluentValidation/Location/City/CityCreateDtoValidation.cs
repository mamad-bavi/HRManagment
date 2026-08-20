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

            RuleFor(c=>c.na)
        }
    }
}
