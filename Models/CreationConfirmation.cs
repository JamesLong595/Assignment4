namespace Assignment4.Models
{
    public class CreationConfirmation
    {
        public string Heading { get; set; }
        public AnnualEnergyConsumption ConsumptionData { get; set; }
        public string Message { get; set; }
        public bool WasSuccessful { get; set; }
    }
}