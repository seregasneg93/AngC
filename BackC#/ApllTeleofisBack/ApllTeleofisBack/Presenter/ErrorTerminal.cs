using ApllTeleofisBack.Models;

namespace ApllTeleofisBack.Presenter
{
    public class ErrorTerminal
    {

        public ErrorTerminal(JournalErrors journalErrors,int idTerminal)
        {
            Id = journalErrors.Id;
            IdTerminal = idTerminal;
            descritionsError = journalErrors.NameDesc;
            DataError = journalErrors.DateError;
        }

        public int Id { get; set; }
        public int IdTerminal { get; set; }
        public string descritionsError { get; set; }
        public DateTime DataError { get; set; }
        public int CountErrors { get; set; }
    }
}
