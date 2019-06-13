using System;
using System.ComponentModel.DataAnnotations;

namespace PorthospNhs.Web.Models
{
    public class PatientViewModel
    {
        [Display(Name = "Unique Identifier")]
        public string UniqueIdentifier { get; set; }

        [Display(Name = "Forenames")]
        public string Forenames { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Postcode")]
        public string Postcode { get; set; }
    }
}