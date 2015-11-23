using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChangeEventDemo.Models
{
    public class Country
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<States> States { get; set; }
    }
}