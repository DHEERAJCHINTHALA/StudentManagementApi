using BALL.RepositoryServices;
using DALL.Models;
using DALL.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    public class CountryController : ApiController
    {
        CountryRepository objdall = new CountryRepository();

        CountryRepositoryServices objball = new CountryRepositoryServices();

        [HttpGet]
        [Route("api/Country/All")]
        public IHttpActionResult GetAllStudents()
        {
            List<Country> students = objball.GetAllCountryList();

            return Ok(students);
        }
    }
}
