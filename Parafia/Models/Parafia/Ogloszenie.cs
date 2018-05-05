using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("OGLOSZENIE")]
    public partial class Ogloszenie
    {
        public int OgloszenieId { get; set; }

        public int KsiadzId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Tytul { get; set; }

        [Required]
        [StringLength(1024)]
        public string Tresc { get; set; }

        [MaxLength(1)]
        public byte[] Zdjecie { get; set; }

        public virtual Ksiadz Ksiadz { get; set; }
    }
}
