using SEProje.ToDo.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.RaporDTOs
{
    public class RaporUpdateDto
    {
        public int Id { get; set; }

        [Display(Name = "Tanım")]
        public string Tanim { get; set; }

        [Display(Name = "Detay")]
        public string Detay { get; set; }

        [Display(Name = "Görev")]
        public int GorevId { get; set; }

        [Display(Name = "Görev")]
        public Gorev Gorev { get; set; }
    }
}
