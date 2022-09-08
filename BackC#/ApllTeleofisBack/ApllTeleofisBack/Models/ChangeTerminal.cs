using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class ChangeTerminal
    {
        [Key]
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string DescRegister { get; set; }
        public double OldValue { get; set; }
        public double NewValue { get; set; }
        public DateTime DateChange { get; set; }
    }
}
