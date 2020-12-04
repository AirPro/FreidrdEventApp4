
using FreidrdEventApp4.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


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

        [HttpPost]
        public ViewResult Edit(int id)
        {

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
