using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Edit
{
    internal class EditMovieCommand : ICommand
    {

        public long ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int SeanceTime { get; set; }

    }
}
