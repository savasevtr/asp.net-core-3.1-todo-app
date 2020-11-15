using FluentValidation;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;

namespace SEProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {
        public GorevAddValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad alanı gereklidir");

            RuleFor(I => I.AciliyetId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}