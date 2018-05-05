using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("MINISTRANT")]
    public partial class Ministrant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ministrant()
        {
            Parafianie = new HashSet<Parafianin>();
        }

        public int MinistrantId { get; set; }

        public int ParafianinId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataRozpoczecia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataZakonczenia { get; set; }

        public virtual ChodziNa ChodziNa { get; set; }

        public virtual Parafianin Parafianin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parafianin> Parafianie { get; set; }
    }
}
