using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Teacher
    {
        [Required]
     
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }=string.Empty;
        [Required]
        public int Password { get; set; }


    }
}
