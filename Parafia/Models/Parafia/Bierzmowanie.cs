using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("BIERZMOWANIE")]
    public partial class Bierzmowanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bierzmowanie()
        {
            Parafianie = new HashSet<Parafianin>();
            Wydarzenia = new HashSet<Wydarzenie>();
        }

        public int BierzmowanieId { get; set; }

        public int SwiadekId { get; set; }

        public int KsiadzId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public virtual Uczestnik Uczestnik { get; set; }

        public virtual Wydarzenie Wydarzenie { get; set; }

        public virtual Ksiadz Ksiadz { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parafianin> Parafianie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }
    }
}
