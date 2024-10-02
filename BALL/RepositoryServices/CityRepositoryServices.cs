using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.RepositoryServices
{
    public class CityRepositoryServices
    {
        CityRepository objdall = new CityRepository();
        public List<City> GetAllCountryList()
        {
            var res = objdall.GetAll().ToList();

            return res;
        }
    }
}
