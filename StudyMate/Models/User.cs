using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class User
    {
        public int nuId;
        public string firstName;
        public string lastName;
        public string major;
        public string emailId;
        public List<string> intClass;
        public List<string> skillSets;

        public User()
        {
            this.NuId = nuId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Major = major;
            this.EmailId = emailId;
            this.IntClass = intClass;
            this.SkillSets = skillSets;
        }

        public int NuId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Major { get; set; }
        public string EmailId { get; set; }
        public List<string> IntClass { get; set; }
        public List<string> SkillSets { get; set; }
        
    }
}
