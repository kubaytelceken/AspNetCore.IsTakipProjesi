﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {
        public GorevAddValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad Alanı Gereklidir.");
            RuleFor(I => I.AciliyetId).ExclusiveBetween(1, int.MaxValue).WithMessage("Lütfen Geçerli Bir Aciliyet Durumu Seçiniz.");
        }
    }
}
