using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
	using System.Text.Encodings.Web;

	public class HelloWorldController : Controller
	{
		// GET: /<controller>/
		public string Index()
		{
			return "This is my default action...";
		}

		// GET: /<controller>/Welcome/{id}
		public string Welcome(string name, int id = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, id: {id}");
		}
	}
}
