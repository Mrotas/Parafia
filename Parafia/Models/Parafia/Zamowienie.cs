using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("ZAMOWIENIE")]
    public partial class Zamowienie
    {
        public int ZamowienieId { get; set; }

        public int WydarzenieId { get; set; }

        public int ParafianinId { get; set; }
    }
}
