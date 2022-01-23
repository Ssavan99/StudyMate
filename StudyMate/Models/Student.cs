using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string EmailId { get; set; }
        public string PasswordHash { get; set; }
        public IList<StudentClass> StudentClass { get; set; }

    }
}
