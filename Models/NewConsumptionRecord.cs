using System;

namespace Assignment4.Models
{
    public class NewConsumptionRecord
    {
        public string SectorName { get; set; }
        public string SourceName { get; set; }
        public int Year { get; set; }
        public Decimal Value { get; set; }
    }
}