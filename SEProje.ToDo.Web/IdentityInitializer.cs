using Microsoft.AspNetCore.Identity;
using SEProje.ToDo.Entities.Concrete;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");

            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");

            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("savas.ev");

            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    Name = "Savaş",
                    Surname = "Ev",
                    UserName = "savas.ev",
                    Email = "savas.ev@yahoo.com"
                };

                await userManager.CreateAsync(user, "1");

                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}