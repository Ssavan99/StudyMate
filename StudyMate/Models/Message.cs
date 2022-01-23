using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
        [ForeignKey("StudentFrom")]
        public int SentFromId { get; set; }
        [ForeignKey("StudentTo")]
        public int SentToId { get; set; }
        //public virtual Student StudentFrom { get; set; }
        public virtual Student StudentTo { get; set; }
    }
}
