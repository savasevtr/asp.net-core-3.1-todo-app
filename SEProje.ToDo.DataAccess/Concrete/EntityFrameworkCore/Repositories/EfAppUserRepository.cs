using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System;
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

        public List<AppUser> GetirAdminOlmayanlar(out int pageCount, string search, int currentPage = 1)
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

                if (!string.IsNullOrWhiteSpace(search))
                {
                    result = result.Where(x => x.Name.ToLower().Contains(search.ToLower()) || x.Surname.ToLower().Contains(search.ToLower()));
                }

                pageCount = (int)Math.Ceiling((double)result.Count() / 3);

                result = result.Skip((currentPage - 1) * 3).Take(3);

                return result.ToList();
            }
        }

        public List<DualHelper> GetirEnCokGorevTamamlamisPersoneller()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler
                     .Include(x => x.AppUser)
                     .Where(x => x.Durum)
                     .GroupBy(x => x.AppUser.UserName)
                     .OrderByDescending(x => x.Count())
                     .Take(5)
                     .Select(x => new DualHelper
                     {
                         Isim = x.Key,
                         GorevSayisi = x.Count()
                     }).ToList();
            }
        }

        public List<DualHelper> GetirEnCokGorevdeCalisanPersoneller()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler
                     .Include(x => x.AppUser)
                     .Where(x => !x.Durum && x.AppUserId != null)
                     .GroupBy(x => x.AppUser.UserName)
                     .OrderByDescending(x => x.Count())
                     .Take(5)
                     .Select(x => new DualHelper
                     {
                         Isim = x.Key,
                         GorevSayisi = x.Count()
                     }).ToList();
            }
        }
    }
}