using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{

    [Table("PARAFIANIN")]
    public partial class Parafianin
    {
        public int ParafianinId { get; set; }

        public int ChrzestId { get; set; }

        public int? BierzmowanieId { get; set; }

        public int? KsiadzId { get; set; }

        public int? MinistrantId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Imie { get; set; }

        [Required]
        [StringLength(1024)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(1024)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataUrodzenia { get; set; }

        [Required]
        [StringLength(1024)]
        public string Miasto { get; set; }

        [Required]
        [StringLength(1024)]
        public string Ulica { get; set; }

        public short? Chrzest { get; set; }

        public short? Bierzmowanie { get; set; }

        public short? Slub { get; set; }

        [Required]
        [StringLength(1024)]
        public string StanCywilny { get; set; }

        public int? IdOjciec { get; set; }

        public int? IdMatka { get; set; }
    }
}
