using Microsoft.Extensions.DependencyInjection;
using SEProje.ToDo.Business.Concrete;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using SEProje.ToDo.DataAccess.Interfaces;

namespace SEProje.ToDo.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGorevService, GorevManager>();
            services.AddScoped<IAciliyetService, AciliyetManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IDosyaService, DosyaManager>();
            services.AddScoped<IBildirimService, BildirimManager>();

            services.AddScoped<IGorevDal, EfGorevRepository>();
            services.AddScoped<IAciliyetDal, EfAciliyetRepository>();
            services.AddScoped<IRaporDal, EfRaporRepository>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IBildirimDal, EfBildirimRepository>();
        }
    }
}
