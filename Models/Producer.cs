using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Profile Picture")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        [Display (Name = "Bio")]
        public string? Bio { get; set; }

        // Realtionships: 1 Producer can produce multiple movies
        // That is: one to Many realtionship from Producer to Movie

        public List<Movie>? Movies { get; set; }
    }
}
