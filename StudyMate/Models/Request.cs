using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public int SentId { get; set; }
        public int ReceivedId { get; set; }

    }
}
