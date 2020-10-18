using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        public List<Kullanici> GetirHepsi()
        {
            throw new NotImplementedException();
        }

        public Kullanici GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public void Güncelle(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Kullanici tablo)
        {
            throw new NotImplementedException();
        }
    }
}
