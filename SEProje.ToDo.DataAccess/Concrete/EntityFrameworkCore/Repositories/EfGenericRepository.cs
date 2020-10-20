using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public List<Tablo> GetirHepsi()
        {
            using (var context = new TodoContext())
            {
                return context.Set<Tablo>().ToList();
            }
        }

        public Tablo GetirIdile(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Set<Tablo>().Find(id);
            }
        }

        public void Güncelle(Tablo tablo)
        {
            using (var context = new TodoContext())
            {
                context.Set<Tablo>().Update(tablo);
                context.SaveChanges();
            }
        }

        public void Kaydet(Tablo tablo)
        {
            using (var context = new TodoContext())
            {
                context.Set<Tablo>().Add(tablo);
                context.SaveChanges();
            }
        }

        public void Sil(Tablo tablo)
        {
            using (var context = new TodoContext())
            {
                context.Set<Tablo>().Remove(tablo);
                context.SaveChanges();
            }
        }
    }
}
