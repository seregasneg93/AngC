namespace ApllTeleofisBack.Models
{
    public class JournalErrors
    {
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string NameDesc { get; set; }
        public DateTime DateError { get; set; }
        public bool Status { get; set; }
    }
}
