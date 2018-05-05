using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parafia.Models.Parafia
{
    [Table("CHODZINA")]
    public partial class ChodziNa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinistrantId { get; set; }

        public virtual Ministrant Ministrant { get; set; }
    }
}
