using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace affnt.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int IdMale { get; set; }
        public int IdFemale { get; set; }

        public Person Person { get; set; }
    }
}