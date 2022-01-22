using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class StudentClass
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
