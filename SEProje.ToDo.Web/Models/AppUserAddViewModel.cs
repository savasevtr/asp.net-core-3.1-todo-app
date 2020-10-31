using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Models
{
    public class AppUserAddViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Parola Tekrar")]
        [Compare("Password", ErrorMessage = "Parolalar eşleşmiyor")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        [EmailAddress(ErrorMessage = "Lüfen geçerli bir email adresi giriniz")]
        public string Email { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string Surname { get; set; }
    }
}