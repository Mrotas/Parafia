using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("DATEK")]
    public partial class Datek
    {
        public int DatekId { get; set; }

        public int? ParafianinId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Email { get; set; }

        [Required]
        [StringLength(1024)]
        public string Typ { get; set; }

        [StringLength(1024)]
        public string Wiadomosc { get; set; }

        public virtual Parafianin Parafianin { get; set; }
    }
}
