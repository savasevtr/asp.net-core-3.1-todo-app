using FluentValidation;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;

namespace SEProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kulllanıcı adı boş geçilemez");

            RuleFor(I => I.Password).NotNull().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}