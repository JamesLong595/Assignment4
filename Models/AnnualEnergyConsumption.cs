using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class AnnualEnergyConsumption
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string ConsumptionId { get; set; }
        public Sector sector { get; set; }
        public EnergySource energysource { get; set; }
        public int Year { get; set; }
        public string Value { get; set; }
    }
}
