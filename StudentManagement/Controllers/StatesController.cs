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
    public class StatesController : ApiController
    {
        StatesRepository objdall = new StatesRepository();

        StatesRepositoryServices objball = new StatesRepositoryServices();

        [HttpGet]
        [Route("api/States/All")]
        public IHttpActionResult GetAllStudents()
        {
            List<States> students = objball.GetAllCountryList();

            return Ok(students);
        }
    }
}
