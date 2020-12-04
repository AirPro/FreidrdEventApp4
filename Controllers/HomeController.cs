using FreidrdEventApp4.Models;
using FreidrdEventApp4.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Controllers
{
	public class HomeController : Controller
	{
        private FreidrdFinalProjectContext context { get; set; }

        public HomeController(FreidrdFinalProjectContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var events = context.Events
                .OrderBy(e => e.EventId)
                .ToList();
            return View(events);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
