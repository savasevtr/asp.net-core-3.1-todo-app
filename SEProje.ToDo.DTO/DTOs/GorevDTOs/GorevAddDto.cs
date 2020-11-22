using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.GorevDTOs
{
    public class GorevAddDto
    {
        public string Ad { get; set; }
        
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Aciliyet Durumu")]
        public int AciliyetId { get; set; }
    }
}