using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
    public class SelectGroups : Controller
    {
		public IActionResult SelectGroup()
		{
			GroupedMoviesViewModel viewModel = new GroupedMoviesViewModel();

			SelectListGroup dramaMovies = new SelectListGroup() { Name = "Dramas" };
			viewModel.Movies.Add(new SelectListItem()
			{
				Group = dramaMovies,
				Text = "Forrest Gump"
			});
			viewModel.Movies.Add(new SelectListItem()
			{
				Group = dramaMovies,
				Text = "Fight Club"
			});

			SelectListGroup comedyMovies = new SelectListGroup() { Name = "Comedies" };
			viewModel.Movies.Add(new SelectListItem()
			{
				Group = comedyMovies,
				Text = "The Legend of Ron Burgundy"
			});
			viewModel.Movies.Add(new SelectListItem()
			{
				Group = comedyMovies,
				Text = "Brothers"
			});

			return View(viewModel);
		}
		public IActionResult EditUser()
		{
			EditUserViewModel viewModel = new EditUserViewModel();
			viewModel.User = new WebUser()
			{
				FirstName = "Hari",
				LastName = "Priya",
				Country = "India"
			};
			viewModel.Countries = new List<string>()
	{
		"India",
		"USA",
		"Germany"
	};
			return View(viewModel);
		}
	}
}
