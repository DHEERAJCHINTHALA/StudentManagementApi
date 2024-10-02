using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Models
{
    public class GetAll
    {
        public int StudentId { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public int Age { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }
        public string Address { set; get; }
        public bool Active { set; get; }
        public string CreatedBy { set; get; }
        public DateTime CreatedOn { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public string CountryName { set; get; }
        public string StatesName { set; get; }
        public string CityName { set; get; }
        public string UnivrsityName { set; get; }
        public string ProgramName { set; get; }
        public string CollegeName { set; get; }
        public int Year { set; get; }
    }
}
