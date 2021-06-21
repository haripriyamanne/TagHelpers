using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
	public class AnchorController : Controller
	{
		public IActionResult List()
		{
			List<Movie> movies = new List<Movie>()
	{
		new Movie() { Id = 1, Title = "The Godfather" },
		new Movie() { Id = 2, Title = "Forrest Gump" },
		new Movie() { Id = 3, Title = "Fight Club" },
	};
			return View(movies);
		}
	}
}
	
