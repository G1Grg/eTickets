using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key] 
        public int Id { get; set; }
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        // Realtionships: 1 Cinema can produce multiple movies
        // That is: one to Many realtionship from Cinema to Movie
        public List<Movie>? Movies { get; set; }

    }
}
