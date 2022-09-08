using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class ChangeClient
    {
        [Key]
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string DescRegister { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateChange { get; set; }
        public string ResultWriteClient { get; set; }
        public string Client { get; set; }
        public string NamePK { get; set; }
    }
}
