using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment4.DataAccess;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class ExploreController : Controller
    {
        private readonly Assignment4DbContext _context;

        public ExploreController(Assignment4DbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string? SectorName, string? SourceName, int? Year)
        {

            return View();
        }
    }
}
