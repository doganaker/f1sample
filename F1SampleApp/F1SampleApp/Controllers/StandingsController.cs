using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace F1SampleApp.Controllers
{
    public class StandingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
