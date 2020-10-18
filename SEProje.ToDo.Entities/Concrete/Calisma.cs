using SEProje.ToDo.Entities.Interfaces;
using System;

namespace SEProje.ToDo.Entities.Concrete
{
    public class Calisma : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }


        public int KullaniciId { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
