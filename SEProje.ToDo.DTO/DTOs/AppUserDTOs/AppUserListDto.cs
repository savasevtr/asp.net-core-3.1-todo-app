using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.DTO.DTOs.AppUserDTOs
{
    public class AppUserListDto
    {
        public int Id { get; set; }

        [Display(Name = "Ad :")]
        public string Name { get; set; }

        [Display(Name = "Soyad :")]
        public string Surname { get; set; }

        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Display(Name = "Profil Fotoğrafı :")]
        public string Picture { get; set; }
    }
}