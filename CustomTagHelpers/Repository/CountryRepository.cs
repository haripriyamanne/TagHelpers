using CustomTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly List<Country> _countries = new List<Country>
        {
            new Country
            {
                Name = "Austria",
                Population = 8764003
            },
            new Country
            {
                Name = "Switzerland",
                Population = 8484130
            },
            new Country
            {
                Name = "China",
                Population = 1419294833
            }
        };

        public IEnumerable<Country> Countries => _countries;

        public void AddCountry(Country country)
        {
            _countries.Add(country);
        }
    }

}
