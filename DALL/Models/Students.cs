using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Models
{
    public class Students
    {
        public int StudentId { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public int Age { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }
        public string Address { set; get; }
        public bool Active { set; get; }
        public string CreatedBy { set; get; }
        public DateTime CreatedOn { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public int CountryId { set; get; }
        public int StatesId { set; get; }
        public int CityId { set; get; }
        public int UnivrsityId { set; get; }
        public int ProgramId { set; get; }
        public int CollegeId { set; get; }

    }
}
