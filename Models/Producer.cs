using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        // Realtionships: 1 Producer can produce multiple movies
        // That is: one to Many realtionship from Producer to Movie

        public List<Movie>? Movies { get; set; }
    }
}
