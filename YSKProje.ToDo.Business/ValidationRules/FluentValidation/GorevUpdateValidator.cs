using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class GorevUpdateValidator : AbstractValidator<GorevUpdateDto>
    {
        public GorevUpdateValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad Alanı Gereklidir.");
            RuleFor(I => I.AciliyetId).ExclusiveBetween(1, int.MaxValue).WithMessage("Lütfen Geçerli Bir Aciliyet Durumu Seçiniz.");
        }
    }
}
