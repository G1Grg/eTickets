using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string? Name { get; set; }

        [Display (Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        // Realtionships: 1 Cinema can produce multiple movies
        // That is: one to Many realtionship from Cinema to Movie
        public List<Movie>? Movies { get; set; }

    }
}
