using CustomTagHelpers.Models;
using CustomTagHelpers.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public HomeController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public ViewResult Index()
        {
            return View(_countryRepository.Countries);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            _countryRepository.AddCountry(country);

            return RedirectToAction("Index");
        }
    }
}
