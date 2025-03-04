﻿using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace eTickets.Models
{
    public class Movie:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Name")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        public double Price { get; set; }

        [Display(Name ="Image")]
        public string? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        //Realtionships
        public List <Actor_Movie>?Actors_Movies { get; set; }

        //Cinemas
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Cinema? Cinema { get; set; }

        //Producer
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }


        public Producer? Producer{ get; set; }
    }
}

