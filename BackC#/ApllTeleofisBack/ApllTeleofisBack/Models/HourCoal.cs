using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class HourCoal
    {
        [Key]
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string NameRegister { get; set; }
        public double ValueRegister { get; set; }
        public DateTime DateWrite { get; set; }
    }
}
