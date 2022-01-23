using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class RequestSent
    {
        [Key]
        public int RequestSentId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
