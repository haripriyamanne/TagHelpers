using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class FavoriteMoviesViewModel
    {
        public List<Movie> Movies { get; set; }

        public List<int> FavoriteMovieIds { get; set; }
    }
}
