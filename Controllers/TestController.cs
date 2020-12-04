using FreidrdEventApp4.Models.DataLayer;
using FreidrdEventApp4.Models.DomainModel;
using Microsoft.AspNetCore.Mvc;

namespace FreidrdEventApp4.Controllers
{
	public class TestController : Controller
	{
		private Repository<Event> events { get; set; }

		public TestController(FreidrdFinalProjectContext ctx) => events = new Repository<Event>(ctx);

		public ViewResult Index()
		{
			var options = new QueryOptions<Event>
			{
				OrderBy = e => e.EventId
			};
			return View(events.List(options));
		}
		[HttpGet]
		public ViewResult Add() => View();

		[HttpPost]
		public IActionResult Add(Event e)
		{
			if (ModelState.IsValid)
			{
				if (e.EventId == 0)
				{
					events.Insert(e);
					events.Save();
				}
				else
				{
					events.Update(e);
					events.Save();
				}
				return RedirectToAction("Index");
			}
			else
			{
				return View(e);
			}
		}


		[HttpGet]
		public ViewResult delete(int id)
		{
			return View(events.get(id));
		}

		[HttpPost]
		public RedirectToActionResult Delete(Event e)
		{
			events.Delete(e);
			events.Save();
			return RedirectToAction("index");
		}
	}
}
