using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public List<Calisma> GetirHepsi()
        {
            using (var context = new TodoContext())
            {
                return context.Calismalar.ToList();
            }
        }

        public Calisma GetirIdile(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Calismalar.Find(id);
            }
        }

        public void Güncelle(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                context.Calismalar.Update(tablo);
                context.SaveChanges();
            }
        }

        public void Kaydet(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                context.Calismalar.Add(tablo);
                context.SaveChanges();
            }
        }

        public void Sil(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                context.Calismalar.Remove(tablo);
                context.SaveChanges();
            }
        }
    }
}
