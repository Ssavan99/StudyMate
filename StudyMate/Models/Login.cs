using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMate.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public virtual Student Student { get; set; }
    }
}
