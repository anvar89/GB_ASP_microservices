using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    public class DotNetMetricsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
