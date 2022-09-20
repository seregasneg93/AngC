namespace ApllTeleofisBack.Models
{
    public class Frequency
    {
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string TypeEngine { get; set; }
        public string TypeFrequency { get; set; }
        public int Modbuss { get; set; }
        public double Current { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastPoll { get; set; }
        public ICollection<FrequencyJournal> FrequencyJournals { get; set; }
        public ICollection<JournalErrrosChastotnick> JournalErrrosChastotnicks { get; set; }
    }
}
