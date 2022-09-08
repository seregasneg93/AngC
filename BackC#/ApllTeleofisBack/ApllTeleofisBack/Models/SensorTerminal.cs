namespace ApllTeleofisBack.Models
{
    public class SensorTerminal
    {
        public int Id { get; set; }
        public Terminal Terminal { get; set; }
        public string NameSensor { get; set; }
        public bool AcessSensor { get; set; }
    }
}
