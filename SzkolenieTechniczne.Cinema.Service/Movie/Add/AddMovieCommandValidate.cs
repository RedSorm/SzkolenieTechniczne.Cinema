using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Movie;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Add
{
    public class AddMovieCommandValidate : AbstractValidator<AddMovieCommand>
    {
        public AddMovieCommandValidate()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1988, 2040);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30,300);
                
        }
    }
}
