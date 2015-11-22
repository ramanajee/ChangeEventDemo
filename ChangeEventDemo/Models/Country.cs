using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChangeEventDemo.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<States> States { get; set; }
    }
}