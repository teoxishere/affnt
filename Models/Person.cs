using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace affnt.Models
{
    public class Person
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        [MaxLength(40,ErrorMessage ="Name cannot be longer then 40 characters")]
        public  string Name { get; set; }

        [Required]
        [Range(18,50,ErrorMessage ="Age should be between {1} and {2}")]
        public  int Age { get; set; }

        [Required]
        public string City { get; set; } 
        
        [MaxLength(600,ErrorMessage ="Description cannot be longer then 600 characters")]
        public string Description { get; set; }

        [Required]
        [RegularExpression("[F]+[M]",ErrorMessage ="Only M or F allowed")]
        [MaxLength(1, ErrorMessage = "M or F")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression("[F]+[M]", ErrorMessage = "Only M or F allowed")]
        [MaxLength(1,ErrorMessage ="M or F")]
        public string LookingFor { get; set; }

        public ICollection<Attribute> Attributes { get; set; }

        public ICollection<Match> Matches { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}