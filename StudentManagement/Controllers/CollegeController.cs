using BALL.RepositoryServices;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    public class CollegeController : ApiController
    {
        CollegeRepository objdall = new CollegeRepository();

        CollegeRepositoryServices objball = new CollegeRepositoryServices();

        [HttpGet]
        [Route("api/College/All")]
        public IHttpActionResult GetAllStudents()
        {
            var Colleges = objball.GetAllColleges().ToList();

            return Ok(Colleges);
        }
    }
}
