using System.ComponentModel.DataAnnotations;

namespace ApllTeleofisBack.Models
{
    public class DataTerminalJournal
    {
        [Key]
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        //  public CheckDataTerminal CheckDataTerminal { get; set; }
        public string DescriptionsTerminalError { get; set; } // описание 
        public double ValueRegister { get; set; } // значение регистра
        public string Flags { get; set; } // тип флага
        public DateTime DateYear { get; set; } // дата и время
        public int NumberRegister { get; set; } // номер регитсра
        public int GroupRegister { get; set; } // группа регистра
    }
}
