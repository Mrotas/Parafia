using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Parafia.Models.Parafia
{
    [Table("OGLOSZENIE")]
    public partial class Ogloszenie
    {
        public int OgloszenieId { get; set; }

        public int KsiadzId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Tytul { get; set; }

        [Required]
        [StringLength(1024)]
        public string Tresc { get; set; }

        [MaxLength(100)]
        public string Zdjecie { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data wpisu")]
        public System.DateTime Data { get; set; }

    }
}
