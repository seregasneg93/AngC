using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class Terminal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameTerminal { get; set; }
        public string IMEI { get; set; }
        [Required]
        public int SlaveId { get; set; }
        public string NumberPhone { get; set; }
        public bool ConnectTerminalJobChannel { get; set; }
        public bool ConnectTerminalServicesChannel { get; set; }
        public bool AcessReadModbuss { get; set; }
        public string Descriptions { get; set; }
        public string AddressObject { get; set; }
        public string TypeServices { get; set; }
        public string Access { get; set; }
        public string TypeAshpan { get; set; }
        public bool Ibr { get; set; }
        public bool PoolChastotnick { get; set; }
        public DateTime DateLastInterrogation { get; set; }
        public DateTime DateLoadCoal { get; set; }
        public DateTime DateChangeAphpan { get; set; }
        public VersionFirtware VersionFirtware { get; set; }
        public ICollection<TerminalSlaveId> TerminalSlaveId { get; set; }
        public ICollection<DataTerminalJournal> DataTerminalJournals { get; set; }
        public ICollection<DataTerminal> DataTerminals { get; set; }
        public ICollection<ChangeTerminal> ChangeTerminals { get; set; }
        public ICollection<JournalErrors> JournalErrors { get; set; }
        public ICollection<HourCoal> HourCoals { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<ChangeClient> ChangeClients { get; set; }
        public ICollection<SettingTerminal> SettingTerminals { get; set; }
        public ICollection<Frequency> Frequencies { get; set; }
        public ICollection<SensorTerminal> SensorTerminals { get; set; }
    }
}
