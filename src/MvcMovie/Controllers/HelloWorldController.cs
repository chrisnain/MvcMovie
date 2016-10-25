using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
	using System.Text.Encodings.Web;

	public class HelloWorldController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return this.View();
		}

		// GET: /<controller>/Welcome/
		public IActionResult Welcome(string name, int numTimes = 1)
		{
			this.ViewData["Message"] = "Hello " + name;
			this.ViewData["NumTimes"] = numTimes;

			return this.View();
		}
	}
}
