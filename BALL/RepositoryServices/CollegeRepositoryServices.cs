using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.RepositoryServices
{
    public class CollegeRepositoryServices
    {
        CollegeRepository objdall = new CollegeRepository();
        public List<College> GetAllColleges()
        {
            var res = objdall.GetAll().ToList();

            return res;
        }
    }
}
