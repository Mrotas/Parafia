using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("UCZESTNIK")]
    public partial class Uczestnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uczestnik()
        {
            Bierzmowania = new HashSet<Bierzmowanie>();
            Slub = new HashSet<Slub>();
            Chrzest = new HashSet<Chrzest>();
        }

        public int UczestnikId { get; set; }

        public int? ParafianinId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Imie { get; set; }

        [Required]
        [StringLength(1024)]
        public string Nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataUrodzenia { get; set; }

        [Required]
        [StringLength(1)]
        public string Plec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bierzmowanie> Bierzmowania { get; set; }

        public virtual Parafianin Parafianin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slub> Slub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chrzest> Chrzest { get; set; }
    }
}
