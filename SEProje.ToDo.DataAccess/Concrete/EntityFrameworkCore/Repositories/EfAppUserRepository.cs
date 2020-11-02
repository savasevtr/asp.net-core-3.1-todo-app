using Microsoft.EntityFrameworkCore.Internal;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
        public List<AppUser> GetirAdminOlmayanlar()
        {
            using (var context = new TodoContext())
            {
                /*
                    select * from AspNetUsers
                    inner join AspNetUserRoles
                    on AspNetUsers.Id = AspNetUserRoles.UserId
                    inner join AspNetRoles
                    on AspNetUserRoles.RoleId = AspNetRoles.Id
                    where AspNetRoles.Name = 'Member'
                 */

                var result = context.Users
                    .Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
                    {
                        user = resultUser,
                        userRole = resultUserRole
                    })
                    .Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
                    {
                        user = resultTable.user,
                        userRoles = resultTable.userRole,
                        roles = resultRole
                    })
                    .Where(x => x.roles.Name != "Admin")
                    .Select(x => new AppUser()
                    {
                        Id = x.user.Id,
                        Name = x.user.Name,
                        Surname = x.user.Surname,
                        Picture = x.user.Picture,
                        Email = x.user.Email,
                        UserName = x.user.UserName
                    }).ToList();

                return result;
            }
        }

        public List<AppUser> GetirAdminOlmayanlar(string aranacakKelime, int aktifSayfa = 1)
        {
            using (var context = new TodoContext())
            {
                var result = context.Users
                    .Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
                    {
                        user = resultUser,
                        userRole = resultUserRole
                    })
                    .Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
                    {
                        user = resultTable.user,
                        userRoles = resultTable.userRole,
                        roles = resultRole
                    })
                    .Where(x => x.roles.Name != "Admin")
                    .Select(x => new AppUser()
                    {
                        Id = x.user.Id,
                        Name = x.user.Name,
                        Surname = x.user.Surname,
                        Picture = x.user.Picture,
                        Email = x.user.Email,
                        UserName = x.user.UserName
                    });

                if (!string.IsNullOrWhiteSpace(aranacakKelime))
                {
                    result = result.Where(x => x.Name.ToLower().Contains(aranacakKelime.ToLower()) || x.Surname.ToLower().Contains(aranacakKelime.ToLower()));
                }

                result = result.Skip((aktifSayfa - 1) * 3).Take(3);

                return result.ToList();
            }
        }
    }
}