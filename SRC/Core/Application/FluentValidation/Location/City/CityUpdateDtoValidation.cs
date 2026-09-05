using Application.Contracts.Location.ProvinceContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Application.ParentFluentValidation.Location.CityValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.FluentValidation.Location.City
{
    public class CityUpdateDtoValidation : AbstractValidator<CityUpdateDto>
    {
        public CityUpdateDtoValidation(IProvinceRepository provinceRepository)
        {
            Include(new CityParentValidator(provinceRepository));

            RuleFor(p => p.Id)
                .NotNull()
                .WithMessage("{PropertyName} cann't be null");
        }
    }
}
