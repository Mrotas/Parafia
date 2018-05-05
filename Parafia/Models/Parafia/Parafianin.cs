using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("PARAFIANIN")]
    public partial class Parafianin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parafianin()
        {
            Chrzty = new HashSet<Chrzest>();
            Datki = new HashSet<Datek>();
            Ksieza = new HashSet<Ksiadz>();
            Ministranci = new HashSet<Ministrant>();
            Uczestnicy = new HashSet<Uczestnik>();
            Zamowienia = new HashSet<Zamowienie>();
        }

        public int ParafianinId { get; set; }

        public int ChrzestId { get; set; }

        public int? BierzmowanieId { get; set; }

        public int? KsiadzId { get; set; }

        public int? MinistrantId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Imie { get; set; }

        [Required]
        [StringLength(1024)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(1024)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataUrodzenia { get; set; }

        [Required]
        [StringLength(1024)]
        public string Miasto { get; set; }

        [Required]
        [StringLength(1024)]
        public string Ulica { get; set; }

        public short? Chrzest { get; set; }

        public short? Bierzmowanie { get; set; }

        public short? Slub { get; set; }

        [Required]
        [StringLength(1024)]
        public string StanCywilny { get; set; }

        public int? IdOjciec { get; set; }

        public int? IdMatka { get; set; }

        public virtual Bierzmowanie Bierzmowanie1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chrzest> Chrzty { get; set; }

        public virtual Chrzest Chrzest2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datek> Datki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ksiadz> Ksieza { get; set; }

        public virtual Ksiadz Ksiadz1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ministrant> Ministranci { get; set; }

        public virtual Ministrant Ministrant1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uczestnik> Uczestnicy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
    }
}
