using SEProje.ToDo.DTO.DTOs.GorevDTOs;

namespace SEProje.ToDo.DTO.DTOs.AppUserDTOs
{
    public class PersonelGorevlendirListDto
    {
        public AppUserListDto AppUser { get; set; }
        public GorevListDto Gorev { get; set; }
    }
}