using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{

    [Table("SLUB")]
    public partial class Slub
    {
        public int SlubId { get; set; }

        public int KsiadzId { get; set; }

        public int IdMalzonek { get; set; }

        public int IdMalzonka { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public int IdSwiadek { get; set; }

        public int IdSwiadkowa { get; set; }
    }
}
