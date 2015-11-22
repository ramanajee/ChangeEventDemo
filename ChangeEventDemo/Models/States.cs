using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChangeEventDemo.Models
{
    public class States
    {
        public string StateId { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual Country Country { get; set; }
    }
}