using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Areas.Member.Models
{
    public class RaporAddViewModel
    {
        [Display(Name = "Görev :")]
        public int GorevId { get; set; }

        [Display(Name = "Tanım :")]
        [Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        public string Tanim { get; set; }
        
        [Display(Name = "Detay :")]
        [Required(ErrorMessage = "Detay alanı boş geçilemez")]
        public string Detay { get; set; }
    }
}