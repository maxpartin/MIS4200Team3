using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team3.Models
{
    public class RecognizePeople
    {
        public int RecognizePeopleID { get; set; }
        public string recognizerFirstName { get; set; }
        public string recognizerLastName { get; set; }
        public string recognizeeFirstName { get; set; }
        public string recognizeeLastName { get; set; }
        public string Values { get; set; }
    }
}