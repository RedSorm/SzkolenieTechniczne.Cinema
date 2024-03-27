using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Add
{
    public sealed class AddMovieCommand : ICommand
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int SeanceTime { get; set; }
        public string Description { get; set; }


    }
}
