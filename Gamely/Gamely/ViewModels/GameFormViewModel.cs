using Gamely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gamely.ViewModels
{
    public class GameFormViewModel
    {
        public IEnumerable<GameGenre> GameGenres { get; set; }
        public Game Game { get; set; }
        public string Title { get; set; }
    }
}