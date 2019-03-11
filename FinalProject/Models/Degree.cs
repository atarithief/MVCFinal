using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Degree
    {
        [Required]
        public int DegreeId { get; set; }

        [Required]
        public string DegreeName { get; set; }
    }
}