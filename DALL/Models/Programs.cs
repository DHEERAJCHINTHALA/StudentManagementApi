using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Models
{
    public class Programs
    {
        public int ProgramId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CreatedBy { set; get; }
        public DateTime CreatedOn { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public int UniversityId { set; get; }
    }
}
