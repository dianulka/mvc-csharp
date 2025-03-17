using System.ComponentModel.DataAnnotations;

namespace MvcGooodBoooks.Models
{
    public class Reader
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Imię")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Review> ?Reviews { get; set; }
    }
}
