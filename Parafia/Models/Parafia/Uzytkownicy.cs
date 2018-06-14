using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("Uzytkownicy")]
    public partial class Uzytkownicy
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Haslo { get; set; }
        public bool Zweryfikowany { get; set; }
        public string KodWeryfikacyjny { get; set; }
        public int ParafianinId { get; set; }
    }

    [MetadataType(typeof(UzytkownicyMetaData))]
    public partial class Uzytkownicy
    {
        public string PotwierdzHaslo { get; set; }
    }

    public class UzytkownicyMetaData
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Imie jest wymagane")]
        [StringLength(1023)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(1023)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [StringLength(1023)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data urodzenia jest wymagana")]
        [Column(TypeName = "date")]
        public DateTime DataUrodzenia { get; set; }

        [Required(ErrorMessage = "Haslo jest wymagane")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Haslo musi zawierac minimum 8 znakow")]
        [StringLength(1023)]
        public string Haslo { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Podane hasla nie sa rowne")]
        public string PotwierdzHaslo { get; set; }
    }
}
