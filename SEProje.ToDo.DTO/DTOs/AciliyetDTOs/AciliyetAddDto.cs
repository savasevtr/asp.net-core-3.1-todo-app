using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.AciliyetDTOs
{
    public class AciliyetAddDto
    {
        [Display(Name = "Tanım")]
        public string Tanim { get; set; }
    }
}