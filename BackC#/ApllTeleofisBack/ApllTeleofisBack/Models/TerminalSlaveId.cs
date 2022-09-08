namespace ApllTeleofisBack.Models
{
    public class TerminalSlaveId
    {
        public int Id { get; set; }
        public string IMEI { get; set; }
        public int Slave { get; set; }
        public Terminal Terminal { get; set; }
    }
}
