using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Models
{
     //"StudentID, FirstName, MiddleName, LastName, Sex, DOB, EPGM, DegreeTitle, Address, City, State, PostalCode, Phone, AltPhone, Email, AltEmail"
    public class Student
    {
        [Required(ErrorMessage = "Required")]
        [DisplayName("Student ID")]
        [StringLength(11, MinimumLength = 9)]
        public string StudentID { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        [StringLength(160)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Sex")]
        [StringLength(15)]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DisplayName("EPGM")]
        [StringLength(8)]
        public string Epgm { get; set; }

        [DisplayName("Degree Title")]
        [StringLength(160)]
        public string DegreeTitle { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Postal Code")]
        [StringLength(10, MinimumLength = 5)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string AltPhone { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Alt Email Address")]
        [EmailAddress]
        public string AltEmail { get; set; }

    }
}