using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class VersionFirtware
    {
        [Key]
        public int Id { get; set; }
        public DateTime VersionFirtwareTerminal { get; set; }
        public string DescriptionFirtware { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
    }
}
