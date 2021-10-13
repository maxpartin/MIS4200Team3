using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team3.Models
{
    public class RegisterSecondary
    {
        [Key]
        public int registerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string businessUnit { get; set; }
        public DateTime hireDate { get; set; }
        public string title { get; set; }
    }
}