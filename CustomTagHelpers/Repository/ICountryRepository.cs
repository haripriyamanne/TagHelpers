using CustomTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries { get; }

        void AddCountry(Country country);
    }
}
