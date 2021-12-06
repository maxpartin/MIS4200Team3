using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team3.Models
{
    public class RecognizePeople
    {
        
        public int RecognizePeopleID { get; set; } 
    [Display(Name =  "Recognizer First Name")]
        public string recognizerFirstName { get; set; } 
        [Display(Name = "Recognizer Last Name")]
        public string recognizerLastName { get; set; } 
        [Display(Name = "Recognizee First Name")]
        public string recognizeeFirstName { get; set; }
        [Display(Name = "Recognizee Last Name")]
        public string recognizeeLastName { get; set; } 

        public string Values { get; set; }
    }
}