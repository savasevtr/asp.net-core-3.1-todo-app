using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SEProje.ToDo.Business.ValidationRules.FluentValidation;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DTO.DTOs.AciliyetDTOs;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;
using SEProje.ToDo.DTO.DTOs.RaporDTOs;
using SEProje.ToDo.Entities.Concrete;
using System;

namespace SEProje.ToDo.Web.CustomCollectionExtensions
{
    public static class CollectionExtension
    {
        public static void AddCustomIdentityConfigure(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<TodoContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "IsTakipCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Index";
            });
        }

        public static void AddCustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AciliyetAddDto>, AciliyetAddValidator>();
            services.AddTransient<IValidator<AciliyetUpdateDto>, AciliyetUpdateValidator>();
            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddValidator>();
            services.AddTransient<IValidator<AppUserSignInDto>, AppUserSignInValidator>();
            services.AddTransient<IValidator<GorevAddDto>, GorevAddValidator>();
            services.AddTransient<IValidator<GorevUpdateDto>, GorevUpdateValidator>();
            services.AddTransient<IValidator<RaporAddDto>, RaporAddValidator>();
            services.AddTransient<IValidator<RaporUpdateDto>, RaporUpdateValidator>();
        }
    }
}
