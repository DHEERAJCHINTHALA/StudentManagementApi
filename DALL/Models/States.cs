using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Models
{
    public class States
    {
        public int StatesId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
        public string CreatedBy { set; get; }
        public DateTime CreatedOn { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }

        public int CountryId { set; get; }
    }
}
