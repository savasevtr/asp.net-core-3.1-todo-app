using SEProje.ToDo.Entities.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEProje.ToDo.Entities.Concrete
{
    public class Calisma : ITablo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ad { get; set; }

        [Column(TypeName = "ntext")]
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
