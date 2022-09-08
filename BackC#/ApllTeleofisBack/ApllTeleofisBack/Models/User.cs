using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; } //
        public string StatusLogin { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
    }
}
