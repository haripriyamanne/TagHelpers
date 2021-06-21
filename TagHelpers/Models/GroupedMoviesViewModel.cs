using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class GroupedMoviesViewModel
    {
        public GroupedMoviesViewModel()
        {
            this.Movies = new List<SelectListItem>();
        }

        public List<SelectListItem> Movies { get; set; }
    }
}
