using Microsoft.AspNetCore.Mvc;

namespace Beantage.CoffeeShopManagementSystem.Api.Controllers
{
	public class EmailNotificationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
