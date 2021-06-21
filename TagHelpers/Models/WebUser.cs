﻿using System.ComponentModel.DataAnnotations;

namespace TagHelpers.Models
{
    public class WebUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }
    }
}