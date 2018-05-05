using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("CHRZEST")]
    public partial class Chrzest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chrzest()
        {
            Parafianie = new HashSet<Parafianin>();
            Wydarzenia = new HashSet<Wydarzenie>();
            Uczestnicy = new HashSet<Uczestnik>();
        }

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

        public virtual Parafianin Parafianin { get; set; }

        public virtual Wydarzenie Wydarzenie { get; set; }

        public virtual Ksiadz Ksiadz { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parafianin> Parafianie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uczestnik> Uczestnicy { get; set; }
    }
}
