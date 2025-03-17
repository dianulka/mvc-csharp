using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcGooodBoooks.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Reader")]
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        [Required]
        [MaxLength(1000)]
        public string ReviewDescription { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Range(0,6)]
        public int StarsGiven{get;set;}
    }
}