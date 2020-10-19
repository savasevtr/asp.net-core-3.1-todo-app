using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        public List<Kullanici> GetirHepsi()
        {
            using (var context = new TodoContext())
            {
                return context.Kullanicilar.ToList();
            }
        }

        public Kullanici GetirIdile(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Kullanicilar.Find(id);
            }
        }

        public void Güncelle(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                context.Kullanicilar.Update(tablo);
                context.SaveChanges();
            }
        }

        public void Kaydet(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                context.Kullanicilar.Add(tablo);
                context.SaveChanges();
            }
        }

        public void Sil(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                context.Kullanicilar.Remove(tablo);
                context.SaveChanges();
            }
        }
    }
}
