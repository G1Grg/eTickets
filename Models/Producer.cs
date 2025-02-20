using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 Chars")]
        public string? FullName { get; set; }

        [Display (Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio { get; set; }

        // Realtionships: 1 Producer can produce multiple movies
        // That is: one to Many realtionship from Producer to Movie

        public List<Movie>? Movies { get; set; }
    }
}
