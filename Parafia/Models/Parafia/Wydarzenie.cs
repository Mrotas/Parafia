using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{

    [Table("WYDARZENIE")]
    public partial class Wydarzenie
    {
        public int WydarzenieId { get; set; }

        public int? IdWydarzenie { get; set; }

        [Required]
        [StringLength(1024)]
        public string Typ { get; set; }

        public double? KosztWydarzenia { get; set; }

        public int? IdZamowienie { get; set; }

        public virtual Bierzmowanie Bierzmowanie { get; set; }
    }
}
