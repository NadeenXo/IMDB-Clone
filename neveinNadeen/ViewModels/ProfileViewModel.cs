using neveinNadeen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neveinNadeen.ViewModels
{
    public class ProfileViewModel
    {
        //##########

            public IMDb_User IMDb_User { get; set; }

            public IEnumerable<Movies> Movie { get; set; }
            public IEnumerable<Actors> Actor { get; set; }
            public IEnumerable<ActorMovies> ActorMovie { get; set; }
            public IEnumerable<Directors> Director { get; set; }

        }
 }

