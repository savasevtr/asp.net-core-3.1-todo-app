using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public List<Calisma> GetirHepsi()
        {
            throw new NotImplementedException();
        }

        public Calisma GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public void Güncelle(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Calisma tablo)
        {
            throw new NotImplementedException();
        }
    }
}
