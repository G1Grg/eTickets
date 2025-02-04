using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display (Name = "Description")]
        public string? Description { get; set; }

        // Realtionships: 1 Cinema can produce multiple movies
        // That is: one to Many realtionship from Cinema to Movie
        public List<Movie>? Movies { get; set; }

    }
}
