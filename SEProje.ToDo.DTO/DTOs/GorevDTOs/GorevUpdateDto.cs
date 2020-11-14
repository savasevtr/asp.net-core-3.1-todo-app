namespace SEProje.ToDo.DTO.DTOs.GorevDTOs
{
    public class GorevUpdateDto
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Ad { get; set; }
        
        public string Aciklama { get; set; }
        
        //[Range(0, int.MaxValue, ErrorMessage = "Lütfen bir aciliyet durumu seçiniz")]
        public int AciliyetId { get; set; }
    }
}