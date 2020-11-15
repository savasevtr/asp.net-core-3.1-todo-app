using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace SEProje.ToDo.DTO.DTOs.GorevDTOs
{
    public class GorevListAllDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public Aciliyet Aciliyet { get; set; }
        public AppUser AppUser { get; set; }
        public List<Rapor> Raporlar { get; set; }
    }
}
