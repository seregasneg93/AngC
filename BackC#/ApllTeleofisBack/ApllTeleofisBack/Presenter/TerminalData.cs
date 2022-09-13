using ApllTeleofisBack.Constants;
using ApllTeleofisBack.Models;
using ApllTeleofisBack.Services;

namespace ApllTeleofisBack.Presenter
{
    public class TerminalData
    {

        public TerminalData(DataTerminal dataTerminal,int idTerminal,DateTime version)
        {
            Id = dataTerminal.Id;
            IdTerminal = idTerminal;
            Descriptions = dataTerminal.DescriptionsTerminalError;

            Value = Convert.ToString(dataTerminal.ValueRegister);

            if (dataTerminal.DescriptionsTerminalError.Contains(ConstatansVariables.РАСПИСАНИЕ_РАБОТЫ))
            {
                Value = ConvertRegister.ReceiveTableJob(version, dataTerminal.ValueRegister);
            }

            if (dataTerminal.DescriptionsTerminalError.Contains(ConstatansVariables.МЕТОД_РЕГУЛИРОВКИ))
            {
                Value = ConvertRegister.ReceiveMethodAdjustment(dataTerminal.ValueRegister);
            }

            Date = dataTerminal.DateYear;
            GroupRegister = dataTerminal.GroupRegister;
        }

        public int Id { get; set; }
        public int IdTerminal { get; set; }
        public string Descriptions { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public int GroupRegister { get; set; }
    }
}
