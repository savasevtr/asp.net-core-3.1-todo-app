using FluentValidation;
using SEProje.ToDo.DTO.DTOs.AciliyetDTOs;

namespace SEProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez!");
        }
    }
}