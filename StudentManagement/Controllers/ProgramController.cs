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
    public class ProgramController : ApiController
    {
        ProgramRepository objdall = new ProgramRepository();

        ProgramRepositoryServices objball = new ProgramRepositoryServices();

        [HttpGet]
        [Route("api/Program/All")]
        public IHttpActionResult GetAllStudents()
        {
            List<Programs> students = objball.GetAllCountryList();

            return Ok(students);
        }
    }
}
