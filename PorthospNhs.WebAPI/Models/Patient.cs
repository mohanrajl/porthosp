using System;

namespace PorthospNhs.WebAPI.Models
{
    public class Patient
    {
        public string UniqueIdentifier { get; set; }

        public string Forenames { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Postcode { get; set; }
    }
}