using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class AnnualEnergyConsumption
    {
        [Key]
        public Sector sector { get; set; }
        [Key]
        public EnergySource energysource { get; set; }
        [Key]
        public int Year { get; set; }
        public int Value { get; set; }
    }
}
