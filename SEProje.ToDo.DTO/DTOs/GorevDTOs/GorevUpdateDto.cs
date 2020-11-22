using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.GorevDTOs
{
    public class GorevUpdateDto
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Aciliyet Durumu")]
        public int AciliyetId { get; set; }
    }
}