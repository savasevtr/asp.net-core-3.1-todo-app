using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.Business.Concrete
{
    class RaportManager : IRaporService
    {
        private readonly EfRaporRepository raporRepository;

        public RaportManager()
        {
            raporRepository = new EfRaporRepository();
        }

        public List<Rapor> GetirHepsi()
        {
            return raporRepository.GetirHepsi();
        }

        public Rapor GetirIdile(int id)
        {
            return raporRepository.GetirIdile(id);
        }

        public void Guncelle(Rapor tablo)
        {
            raporRepository.Guncelle(tablo);
        }

        public void Kaydet(Rapor tablo)
        {
            raporRepository.Kaydet(tablo);
        }

        public void Sil(Rapor tablo)
        {
            raporRepository.Sil(tablo);
        }
    }
}
