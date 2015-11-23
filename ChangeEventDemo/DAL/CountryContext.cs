using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ChangeEventDemo.Models;

namespace ChangeEventDemo.DAL
{
    public class CountryContext : DbContext
    {
        public CountryContext():base("EevntsConnection")
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<States> States { get; set; }
    }
}