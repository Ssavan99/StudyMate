using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class RequestReceived
    {
        public int RequestReceivedId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
