namespace ApllTeleofisBack.Models
{
    public class FrequencyJournal
    {
        public int Id { get; set; }
        public Frequency Frequency { get; set; }
        public string NameRegister { get; set; }
        public string ValueRegister { get; set; }
        public DateTime DatePoll { get; set; }
    }
}
