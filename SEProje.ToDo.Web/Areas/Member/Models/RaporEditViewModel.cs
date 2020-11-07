using SEProje.ToDo.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Areas.Member.Models
{
    public class RaporEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Görev :")]
        public int GorevId { get; set; }

        public Gorev Gorev { get; set; }

        [Display(Name = "Tanım :")]
        [Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        public string Tanim { get; set; }

        [Display(Name = "Detay :")]
        [Required(ErrorMessage = "Detay alanı boş geçilemez")]
        public string Detay { get; set; }
    }
}
