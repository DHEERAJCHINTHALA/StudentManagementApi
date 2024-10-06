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
    public class AuthenticationController : ApiController
    {
        AuthenticationRepository objdall = new AuthenticationRepository();

        AuthenticationRepositoryServices objball = new AuthenticationRepositoryServices();

        [HttpPost]

        public IHttpActionResult LoginAdmin(Admin obj)
        {
            int id = objball.Login(obj);

            return  Ok(id);

            
        }


    }
}
