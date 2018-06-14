using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("KOLEDA")]
    public partial class Koleda
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KsiadzId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Data { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1024)]
        public string Miasto { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1024)]
        public string Ulica { get; set; }

        public int? Datek { get; set; }

        public short? Nieobecny { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMinistrant { get; set; }

        public int? IdMinistrant2 { get; set; }
    }
}
