using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Areas.Admin.Models
{
    public class AppUserListViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ad:")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }

        [Display(Name = "Soyad:")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string Surname { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        public string Email { get; set; }
        
        [Display(Name = "Profil Fotoğrafı:")]
        public string Picture { get; set; }
    }
}
