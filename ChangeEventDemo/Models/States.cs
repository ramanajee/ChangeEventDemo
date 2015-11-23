using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChangeEventDemo.Models
{
    public class States
    {
        [Key]
        public string StateId { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}