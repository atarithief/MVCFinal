//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Starting Quarter")]
        public string QuarterStart { get; set; }

        [Display(Name = "SID")]
        public string StudentNumber { get; set; }

        [Required]
        [Display(Name = "First")]
        public string FirstName { get; set; }

        [Display(Name = "Middle")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        public System.DateTime DOB { get; set; }

        [Display(Name = "Degree Type")]
        public Nullable<int> DegreeType { get; set; }

        [Display(Name = "Degree Title")]
        public Nullable<int> Degree { get; set; }

        [Display(Name = "Benefits")]
        public Nullable<int> VaChapter { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Alt Phone")]
        [Phone]
        public string AltPhone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [EmailAddress]
        [Display(Name = "Alt Email")]
        public string AltEmail { get; set; }
    
        [Display(Name = "Degree Title")]
        public virtual DegreeTitle DegreeTitle { get; set; }

        [Display(Name = "Degree Type")]
        public virtual DegreeType DegreeType1 { get; set; }

        [Display(Name = "Benefits")]
        public virtual VaChapter VaChapter1 { get; set; }
    }
}
