using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Areas.Admin.Models
{
    public class AciliyetEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Tanım")]
        [Required(ErrorMessage = "Tanım alanı boş geçilemez!")]
        public string Tanim { get; set; }
    }
}
