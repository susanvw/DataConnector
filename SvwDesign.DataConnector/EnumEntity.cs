using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SvwDesign.DataConnector
{
    public class EnumEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(32)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(64)]
        public string Description { get; set; } = string.Empty;
    }
}
