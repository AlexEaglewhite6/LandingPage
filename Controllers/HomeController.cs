using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandingPage.Models;

namespace LandingPage.Controllers
{
	
	public class HomeController : Controller
	{
		ApplicationContext db;
		public HomeController(ApplicationContext context) => db = context;
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(Client client)
		{
			try
			{
				db.Clients.Add(client);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			catch
			{
				return Redirect("~/Home/Index/#contact");
			}
			
		}
	}
}
