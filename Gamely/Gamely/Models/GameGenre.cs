using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gamely.Models
{
    public class GameGenre
    {
        [Display(Name = "Жанр")]
        public byte Id { get; set; }

        [Display(Name = "Жанр")]
        public string Name { get; set; }
    }
}