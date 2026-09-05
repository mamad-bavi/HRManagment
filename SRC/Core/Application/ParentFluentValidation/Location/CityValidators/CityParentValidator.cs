using Application.Contracts.Location.CityContract;
using Application.Contracts.Location.ProvinceContract;
using Application.DTOParent.Location;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ParentFluentValidation.Location.CityValidators
{
    public class CityParentValidator : AbstractValidator<ICityDtoParent>
    {
        private readonly IProvinceRepository provinceRepository;

        public CityParentValidator(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;

            RuleFor(c => c.Name)
                .MaximumLength(100)
                .WithMessage("{PropertyName} نباید بیش از 100 کاراکتر باشد");

            RuleFor(c => c.ProvinceId)
                .NotNull()
                .WithMessage("{PropertyName} cann't be null")
                .GreaterThan(0)
                .WithMessage("{PropertyName} cann't be 0 or less 0")
                .MustAsync(async (id, token) =>
                {
                    return !(await this.provinceRepository.Exist(id));
                })
                .WithMessage("not found province");

        }
    }
}
