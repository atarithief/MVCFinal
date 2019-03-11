using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class VaChapter
    {
        [Required]
        public int ChapterId { get; set; }

        [Required]
        public string ChapterName { get; set; }
    }
}