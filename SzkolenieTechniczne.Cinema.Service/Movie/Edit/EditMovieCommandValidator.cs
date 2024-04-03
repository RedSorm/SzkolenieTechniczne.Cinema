using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Edit
{
    internal class EditMovieCommandValidator : AbstractValidator<EditMovieCommand>

    {
        public EditMovieCommandValidator() 
        {
            RuleFor(x => x.ID).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1988, 2040);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);


        }

    }
}
