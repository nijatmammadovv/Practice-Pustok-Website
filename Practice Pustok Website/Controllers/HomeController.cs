using Microsoft.AspNetCore.Mvc;
using Practice_Pustok_Website.Data_access_layer;
using Practice_Pustok_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Pustok_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.sliders.ToList();
            
            return View(sliders);
        }
    }
}
