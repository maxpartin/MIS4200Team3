using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MIS4200Team3.Models;

namespace MIS4200Team3.DAL
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("name=DefaultConnection")
        {

        }


        public DbSet<RegisterSecondary> RegisterSecondary { get; set; }

        
        
    }
}