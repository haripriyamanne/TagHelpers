using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLHelpers.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public Branch Branch { get; set; }
        public int Age { get; set; }
    }
    public enum Branch
    {
        CSE,
        ECE,
        IT
    }
}
