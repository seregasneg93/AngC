namespace ApllTeleofisBack.Models
{
    public class JournalErrrosChastotnick
    {
        public int Id { get; set; }
        public Frequency Frequency { get; set; }
        public string NameError { get; set; }
        public bool ActualError { get; set; }
        public DateTime DateError { get; set; }
    }
}
