using Microsoft.EntityFrameworkCore;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfRaporRepository : EfGenericRepository<Rapor>, IRaporDal
    {
        public Rapor GetirGorevileId(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Raporlar.Include(x => x.Gorev).ThenInclude(x => x.Aciliyet).Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public int GetirRaporSayisi()
        {
            using (var context = new TodoContext())
            {
                return context.Raporlar.Count();
            }
        }

        public int GetirRaporSayisiileAppUserId(int id)
        {
            using (var context = new TodoContext())
            {
                var result = context.Gorevler.Include(x => x.Raporlar).Where(x => x.AppUserId == id);

                return result.SelectMany(x => x.Raporlar).Count();
            }
        }
    }
}