using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.DTO.DTOs.RaporDTOs
{
    public class RaporUpdateDto
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Detay { get; set; }
        public int GorevId { get; set; }
    }
}
