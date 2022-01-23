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

        [ForeignKey("StudentSent")]
        public int SentId { get; set; }
        [ForeignKey("StudentReceived")]
        public int ReceivedId { get; set; }

        //public virtual Student StudentSent { get; set; }
        public virtual Student StudentReceived { get; set; }

    }
}
