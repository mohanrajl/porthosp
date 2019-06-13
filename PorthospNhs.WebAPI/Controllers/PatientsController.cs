using PorthospNhs.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PorthospNhs.WebAPI.Controllers
{
    public class PatientsController : ApiController
    {   
        public IHttpActionResult GetAllPatients()
        {
            var patients = GetPatients();

            return Ok(patients);
        }

        private static List<Patient> GetPatients()
        {
            return new List<Patient>()
            {
                new Patient
                {
                    UniqueIdentifier = "001",
                    Forenames = "Mickey",
                    Surname = "Mouse",
                    DateOfBirth = new DateTime(1928, 11, 18),
                    Postcode = "PO1 1AA"
                },
                new Patient
                {
                    UniqueIdentifier = "002",
                    Forenames = "Han",
                    Surname = "Solo",
                    DateOfBirth = new DateTime(1947, 12, 27),
                    Postcode = "SO1 1AA"
                },
                new Patient
                {
                    UniqueIdentifier = "003",
                    Forenames = "John",
                    Surname = "Lennon",
                    DateOfBirth = new DateTime(1940, 10, 09),
                    Postcode = null
                }
            };
        }
    }
}
