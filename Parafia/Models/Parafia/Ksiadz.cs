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
            Chrzty = new HashSet<Chrzest>();
            Koledy = new HashSet<Koleda>();
            Ogloszenia = new HashSet<Ogloszenie>();
            Parafianie = new HashSet<Parafianin>();
            Sluby = new HashSet<Slub>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chrzest> Chrzty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koleda> Koledy { get; set; }

        public virtual Parafianin Parafianin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogloszenie> Ogloszenia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parafianin> Parafianie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slub> Sluby { get; set; }
    }
}
