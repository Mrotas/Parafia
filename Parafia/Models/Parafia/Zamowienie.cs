using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("ZAMOWIENIE")]
    public partial class Zamowienie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie()
        {
            Wydarzenia = new HashSet<Wydarzenie>();
        }

        public int ZamowienieId { get; set; }

        public int WydarzenieId { get; set; }

        public int ParafianinId { get; set; }

        public virtual Parafianin Parafianin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }

        public virtual Wydarzenie Wydarzenie { get; set; }
    }
}
