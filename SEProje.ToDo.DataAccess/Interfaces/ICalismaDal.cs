using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Interfaces
{
    public interface ICalismaDal
    {
        void Kaydet(Calisma tablo);
        void Sil(Calisma tablo);
        void Güncelle(Calisma tablo);
        Calisma GetirIdile(int id);
        List<Calisma> GetirHepsi();
    }
}