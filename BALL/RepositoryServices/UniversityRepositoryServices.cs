using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.RepositoryServices
{
    public class UniversityRepositoryServices
    {
        UniversityRepository objdall = new UniversityRepository();
        public List<University> GetAllCountryList()
        {
            var res = objdall.GetAll().ToList();

            return res;
        }
    }
}
