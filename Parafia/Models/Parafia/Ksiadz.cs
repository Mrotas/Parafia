using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("KSIADZ")]
    public partial class Ksiadz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ksiadz()
        {
            Bierzmowania = new HashSet<Bierzmowanie>();
        }

        public int KsiadzId { get; set; }

        public int? ParafianinId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Stanowisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataRozpoczecia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataZakonczenia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bierzmowanie> Bierzmowania { get; set; }
    }
}
