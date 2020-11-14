using FluentValidation;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;

namespace SEProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class GorevUpdateValidator : AbstractValidator<GorevUpdateDto>
    {
        public GorevUpdateValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad alanı gereklidir");

            RuleFor(I => I.AciliyetId).ExclusiveBetween(1, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}