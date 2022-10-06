﻿namespace RentAMovie.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Director
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //public  Photo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Movie> DirectedMovies { get; set; } = new List<Movie>();
    }
}