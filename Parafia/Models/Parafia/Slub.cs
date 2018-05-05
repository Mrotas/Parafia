using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("SLUB")]
    public partial class Slub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Slub()
        {
            Wydarzenia = new HashSet<Wydarzenie>();
            Uczestnicy = new HashSet<Uczestnik>();
        }

        public int SlubId { get; set; }

        public int KsiadzId { get; set; }

        public int IdMalzonek { get; set; }

        public int IdMalzonka { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public int IdSwiadek { get; set; }

        public int IdSwiadkowa { get; set; }

        public virtual Ksiadz Ksiadz { get; set; }

        public virtual Wydarzenie Wydarzenie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uczestnik> Uczestnicy { get; set; }
    }
}
