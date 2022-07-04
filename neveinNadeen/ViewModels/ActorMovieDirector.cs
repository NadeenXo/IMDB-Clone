using neveinNadeen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neveinNadeen.ViewModels
{
    public class ActorMovieDirector
    {
        public List<Movies> Movie { get; set; }
        public List<Actors> Actor { get; set; }
        public List<ActorMovies> ActorMovie { get; set; }
        public List<Directors> Director { get; set; }
    }
}