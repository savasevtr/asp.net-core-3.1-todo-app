using Microsoft.EntityFrameworkCore;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public Gorev GetirAciliyetileId(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Include(x => x.Aciliyet).FirstOrDefault(x => !x.Durum && x.Id == id);
            }
        }

        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Where(x => x.Durum == false).Include(x => x.Aciliyet).OrderByDescending(x => x.OlusturmaTarihi).ToList();
            }
        }

        public List<Gorev> GetirileAppUserId(int appUserId)
        {
            using var context = new TodoContext();

            return context.Gorevler.Where(x => x.AppUserId == appUserId).ToList();
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler
                    .Include(x => x.Aciliyet)
                    .Include(x => x.Raporlar)
                    .Include(x => x.AppUser)
                    .Where(x => !x.Durum)
                    .OrderByDescending(x => x.OlusturmaTarihi)
                    .ToList();
            }
        }

        public List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter)
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler
                    .Include(x => x.Aciliyet)
                    .Include(x => x.Raporlar)
                    .Include(x => x.AppUser)
                    .Where(filter)
                    .OrderByDescending(x => x.OlusturmaTarihi)
                    .ToList();
            }
        }

        public Gorev GetirRaporlarileId(int id)
        {
            using var context = new TodoContext();

            return context.Gorevler.Include(x => x.Raporlar).Include(y => y.AppUser).Where(z => z.Id == id).FirstOrDefault();
        }

        public List<Gorev> GetirTumTablolarlaTamamlanan(out int pageCount, int userId ,int currentPage = 1)
        {
            using var context = new TodoContext();

            var returnValue = context.Gorevler.Include(x => x.Aciliyet)
                .Include(x => x.Raporlar)
                .Include(x => x.AppUser)
                .Where(x => x.AppUserId == userId && x.Durum)
                .OrderByDescending(x => x.OlusturmaTarihi);

            pageCount = (int)Math.Ceiling((double)returnValue.Count() / 3);

            return returnValue.Skip((currentPage - 1) * 3).Take(3).ToList();
        }
    }
}