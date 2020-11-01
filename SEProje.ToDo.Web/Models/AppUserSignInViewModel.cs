using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Models
{
    public class AppUserSignInViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
