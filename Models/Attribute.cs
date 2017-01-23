using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace affnt.Models
{
    public class Attribute
    {
        [Key]
        public int Id { get; set; }

        public int Intelligence { get; set; }

        public int Cuteness { get; set; }

        public int Funny { get; set; }

        public int Sensitiveness { get; set; }

        public int EzotericAbilities { get; set; }

        public ICollection<Person> Persons { get; set; }

    }
}