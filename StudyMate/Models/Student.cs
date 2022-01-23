using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Student
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }
        public int NuId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public string EmailId { get; set; }

        public IList<StudentClass> StudentClass { get; set; }
        public IList<RequestSent> RequestSent { get; set; }

        public IList<RequestReceived> RequestReceived { get; set; }
    }
}
