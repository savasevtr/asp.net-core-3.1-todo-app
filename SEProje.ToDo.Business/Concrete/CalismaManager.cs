using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.Business.Concrete
{
    public class CalismaManager : ICalismaService
    {
        private readonly EfCalismaRepository efCalismaRepository;

        public CalismaManager()
        {
            efCalismaRepository = new EfCalismaRepository();
        }

        public List<Calisma> GetirHepsi()
        {
            return efCalismaRepository.GetirHepsi();
        }

        public Calisma GetirIdile(int id)
        {
            return efCalismaRepository.GetirIdile(id);
        }

        public void Güncelle(Calisma tablo)
        {
            efCalismaRepository.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            efCalismaRepository.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCalismaRepository.Sil(tablo);
        }
    }
}
