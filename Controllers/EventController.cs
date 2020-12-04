using FreidrdEventApp4.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace FreidrdEventApp4.Controllers
{
	public class EventController : Controller
	{
		private EventUnitOfWork events { get; set; }

		public EventController(FreidrdFinalProjectContext ctx) => events = new EventUnitOfWork(ctx);

		[HttpGet]
		public ViewResult Add()
		{
			return View();
		}

		[HttpPost]
		public ViewResult Edit(int id)
		{

			return View();

		}
	}
}
