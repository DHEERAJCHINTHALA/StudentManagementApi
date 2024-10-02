using BALL.RepositoryServices;
using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    public class CityController : ApiController
    {
        CityRepository objdall = new CityRepository();

        CityRepositoryServices objball = new CityRepositoryServices();

        [HttpGet]
        [Route("api/City/All")]
        public IHttpActionResult GetAllStudents()
        {
            List<City> students = objball.GetAllCountryList();

            return Ok(students);
        }
    }
}
