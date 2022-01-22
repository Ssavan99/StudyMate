using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
        public int SentFromId { get; set; }
        public int SentToId { get; set; }
    }
}
