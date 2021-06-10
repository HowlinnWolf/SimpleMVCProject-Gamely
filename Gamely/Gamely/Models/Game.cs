using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gamely.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        public GameGenre GameGenre { get; set; }

        [Required]
        [Display(Name = "Жанр")]
        public byte GameGenreId { get; set; }

        [Required]
        [Display(Name = "Дата выхода")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Дата добавления")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 50)]
        [Display(Name = "В наличии")]
        public byte NumberInStock { get; set; }
    }
}