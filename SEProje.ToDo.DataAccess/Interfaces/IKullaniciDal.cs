using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Interfaces
{
    public interface IKullaniciDal
    {
        void Kaydet(Kullanici tablo);
        void Sil(Kullanici tablo);
        void Güncelle(Kullanici tablo);
        Kullanici GetirIdile(int id);
        List<Kullanici> GetirHepsi();
    }
}
