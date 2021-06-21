using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class EditUserViewModel
    {
        public WebUser User { get; set; }

        public List<string> Countries { get; set; }
        [MinLength(10)]
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
