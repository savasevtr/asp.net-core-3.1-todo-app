using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBildirimRepository : EfGenericRepository<Bildirim>, IBildirimDal
    {
        public List<Bildirim> GetirOkunmayanlar(int AppUserId)
        {
            using (var context = new TodoContext())
            {
                return context.Bildirimler.Where(I => I.AppUserId == AppUserId && !I.Durum).ToList();
            }
        }

        public int GetirOkunmayanSayisiileAppUserId(int AppUserId)
        {
            using (var context = new TodoContext())
            {
                return context.Bildirimler.Count(I => I.AppUserId == AppUserId && !I.Durum);
            }
        }
    }
}