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
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Business Unit")]
        public string businessUnit { get; set; }
        [Display(Name = "Date Hired")]
        public DateTime hireDate { get; set; }
        [Display(Name = "Title")]
        public string title { get; set; }
    }
}