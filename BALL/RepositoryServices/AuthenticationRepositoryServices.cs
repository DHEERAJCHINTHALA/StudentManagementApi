using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.RepositoryServices
{
    public class AuthenticationRepositoryServices
    {
        AuthenticationRepository objdall = new AuthenticationRepository();
        public int Login(Admin obj)
        {
            int i = objdall.LoginAdmin(obj);

            return i;
        }
    }
}
