using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment4.DataAccess;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class CreateController : Controller
    {
        private readonly Assignment4DbContext _context;

        public CreateController(Assignment4DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateConsumptionRecord(NewConsumptionRecord newRecord)
        {
            Sector sector = _context.Sector.Where(s => s.SectorName == newRecord.SectorName).First();
            EnergySource energySource = _context.EnergySource.Where(e => e.SourceName == newRecord.SourceName).First();
            AnnualEnergyConsumption newConsumption = new AnnualEnergyConsumption();
            newConsumption.sector = sector;
            newConsumption.energysource = energySource;
            newConsumption.Year = Convert.ToInt32(newRecord.Year);
            newConsumption.Value = newRecord.Value;
            _context.AnnualEnergyConsumption.Add(newConsumption);
            _context.SaveChanges();
            return RedirectToAction("Index", "Explore");
        }
    }
}
