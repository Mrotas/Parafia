using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("BIERZMOWANIE")]
    public partial class Bierzmowanie
    {
        public int Bierzmowanieid { get; set; }

        public int Swiadekid { get; set; }

        public int Ksiadzid { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public virtual Uczestnik Uczestnik { get; set; }

        public virtual Wydarzenie Wydarzenie { get; set; }

        public virtual Ksiadz Ksiadz { get; set; }
    }
}