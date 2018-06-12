using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("CHRZEST")]
    public partial class Chrzest
    {
        public int ChrzestId { get; set; }

        public int? ParafianinId { get; set; }

        public int KsiadzId { get; set; }

        [Required]
        [StringLength(1024)]
        public string ImieDziecka { get; set; }

        [StringLength(1024)]
        public string ImieDziecka2 { get; set; }

        [Required]
        [StringLength(1)]
        public string Plec { get; set; }

        public int IdOjciec { get; set; }

        public int IdMatka { get; set; }

        public int IdOjciecChrzestny { get; set; }

        public int IdMatkaChrzestna { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataChrztu { get; set; }
    }
}
