using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.AppUserDTOs
{
    public class AppUserAddDto
    {
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar :")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Ad :")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }
    }
}
