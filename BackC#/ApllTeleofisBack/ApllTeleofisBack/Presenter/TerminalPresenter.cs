using ApllTeleofisBack.Models;

namespace ApllTeleofisBack.Presenter
{
    public class TerminalPresenter
    {

        public TerminalPresenter(Terminal terminal, List<TerminalData> dataTerminals, List<ErrorTerminal> journalErrors)
        {
            Id = terminal.Id;
            NameTerminal = terminal.NameTerminal;

            TerminalDatas = new();
            ErrorTerminals = new();

            if (journalErrors.Count > 0)
            {
                var findLast = journalErrors.OrderByDescending(x => x.DataError).First();
                if (findLast != null)
                    LastError = findLast.DataError;
            }
            else
                LastError = new();

            TerminalDatas.AddRange(dataTerminals);
            ErrorTerminals.AddRange(journalErrors);
        }

        public int Id { get; set; }
        public string NameTerminal { get; set; }
        public DateTime LastError { get; set; }
        public List<TerminalData> TerminalDatas { get; set; }
        public List<ErrorTerminal> ErrorTerminals { get; set; }
    }
}
