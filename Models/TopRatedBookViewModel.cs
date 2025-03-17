using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcGooodBoooks.Models
{
     public class TopRatedBookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double AverageRating { get; set; }
    }
}