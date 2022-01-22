using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class User
    {
        public int NuId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Major { get; set; }
        public string EmailId { get; set; }
        public List<string> IntClass { get; set; }
        public List<string> SkillSets { get; set; }
        
    }
}
