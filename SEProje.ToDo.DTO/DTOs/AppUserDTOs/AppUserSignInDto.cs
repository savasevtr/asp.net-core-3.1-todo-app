using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.AppUserDTOs
{
    public class AppUserSignInDto
    {
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [Display(Name = "Şifre :")]
        public string Password { get; set; }
        
        [Display(Name = "Beni Hatırla :")]
        public bool RememberMe { get; set; }
    }
}