using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("MINISTRANT")]
    public partial class Ministrant
    {
        public int MinistrantId { get; set; }

        public int ParafianinId { get; set; }

        public int IdParafianin { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataRozpoczcia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataZakonczenia { get; set; }

        public virtual ChodziNa ChodziNa { get; set; }
    }
}
