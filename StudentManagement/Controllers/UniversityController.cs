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
    public class UniversityController : ApiController
    {
        UniversityRepository objdall = new UniversityRepository();

        UniversityRepositoryServices objball = new UniversityRepositoryServices();

        [HttpGet]
        [Route("api/University/All")]
        public IHttpActionResult GetAllStudents()
        {
            List<University> students = objball.GetAllCountryList();

            return Ok(students);
        }
    }
}
