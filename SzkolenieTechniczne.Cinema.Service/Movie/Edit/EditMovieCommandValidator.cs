using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Edit
{
    internal class EditMovieCommandValidator : AbstractValidator<EditMovieCommand>

    {
        public EditMovieCommandValidator() 
        {
        
        }

    }
}
