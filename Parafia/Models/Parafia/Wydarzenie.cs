using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("WYDARZENIE")]
    public partial class Wydarzenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wydarzenie()
        {
            Zamowienia = new HashSet<Zamowienie>();
        }
        
        public int? IdWydarzenie { get; set; }

        [Required]
        [StringLength(1024)]
        public string Typ { get; set; }

        public double? KosztWydarzenia { get; set; }

        public int? IdZamowienie { get; set; }

        public virtual Bierzmowanie Bierzmowanie { get; set; }

        public virtual Bierzmowanie BIERZMOWANIE1 { get; set; }

        public virtual Chrzest Chrzest { get; set; }

        public virtual Chrzest CHRZEST1 { get; set; }

        public virtual Slub Slub { get; set; }

        public virtual Slub SLUB1 { get; set; }

        public virtual Zamowienie Zamowienie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
    }
}
