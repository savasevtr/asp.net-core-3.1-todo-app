using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly EfKullaniciRepository efKullaniciRepository;

        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }

        public List<Kullanici> GetirHepsi()
        {
            return efKullaniciRepository.GetirHepsi();
        }

        public Kullanici GetirIdile(int id)
        {
            return efKullaniciRepository.GetirIdile(id);
        }

        public void Güncelle(Kullanici tablo)
        {
            efKullaniciRepository.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepository.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepository.Sil(tablo);
        }
    }
}
