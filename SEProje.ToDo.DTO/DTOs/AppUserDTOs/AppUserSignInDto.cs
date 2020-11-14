using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.AppUserDTOs
{
    public class AppUserSignInDto
    {
        //[Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        //[Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Parola:")]
        //[Required(ErrorMessage = "Parola alanı boş geçilemez")]
        public string Password { get; set; }
        
        //[Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}