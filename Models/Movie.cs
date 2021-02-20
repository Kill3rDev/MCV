using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public class MovieGenreViewModel
        {
            public List<Movie> Movies { get; set; }
            public SelectList Genres { get; set; }
            public string MovieGenre { get; set; }
            public string SearchString { get; set; }
        }
    }
}