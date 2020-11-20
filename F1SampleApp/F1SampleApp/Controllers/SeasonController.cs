using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1SampleApp.Controllers
{
    public class SeasonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeasonDetail()
        {
            return View();
        }
    }
}
