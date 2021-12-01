using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team3.Models
{
    public class Award
    {
        public int ID { get; set; }
        [Display(Name ="Core value recognized")]
        public CoreValue award { get; set; }
        [Display(Name ="Person giving recognition")]
        public string recognizor { get; set; }
        [Display(Name ="Person reciving the recognition")]
        public string recognized { get; set; }
        [Display(Name = "Date recognition given")]
        public DateTime recognizationDate { get; set; }
        public enum CoreValue
        {
            Excellence = 1,
            Integrity = 2,
            Stewardship = 3,
            Innovate = 4,
            Balance = 5
        }

    }
}