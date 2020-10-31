using System;
using System.ComponentModel.DataAnnotations;

namespace SEProje.ToDo.Web.Areas.Admin.Models
{
    public class GorevAddViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Ad { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        // public bool Durum { get; set; }

        [Display(Name = "Aciliyet Durumu")]
        [Range(0, int.MaxValue, ErrorMessage = "Lütfen bir aciliyet durumu seçiniz")]
        public int AciliyetId { get; set; }
    }
}
