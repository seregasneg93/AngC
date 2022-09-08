using ApllTeleofisBack.Models;
using Microsoft.EntityFrameworkCore;

namespace ApllTeleofisBack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<VersionFirtware> VersionFirtwares { get; set; } = null;
        public DbSet<Terminal> Terminals { get; set; } = null;
        public DbSet<TerminalSlaveId> TerminalSlaveIds { get; set; } = null;
        public DbSet<DataTerminalJournal> DataTerminalJournals { get; set; } = null;
        public DbSet<DataTerminal> DataTerminals { get; set; } = null;
        public DbSet<HourCoal> HourCoals { get; set; } = null;
        public DbSet<ChangeTerminal> ChangeTerminals { get; set; } = null;
        public DbSet<JournalErrors> JournalErrors { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;
        public DbSet<ChangeClient> ChangeClients { get; set; } = null;
        public DbSet<SettingTerminal> SettingTerminals { get; set; } = null;
        public DbSet<Frequency> Frequencies { get; set; } = null;
        public DbSet<FrequencyJournal> FrequencyJournals { get; set; } = null;
        public DbSet<JournalErrrosChastotnick> JournalErrrosChastotnicks { get; set; } = null;
        public DbSet<SensorTerminal> SensorTerminals { get; set; } = null;

    }
}
