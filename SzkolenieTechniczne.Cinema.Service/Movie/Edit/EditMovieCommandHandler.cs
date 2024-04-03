using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Edit
{
    internal class EditMovieCommandHandler : ICommandHandler<EditMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public EditMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }



        public Result Handle(EditMovieCommand command)
        {
            var validationResult = new EditMovieCommandValidator().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }
            var movie = _repository.GetMovieById(command.ID);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist");
            }


            movie.Name = command.Name;
            movie.Year = command.Year;
            movie.TimeMinutes = command.SeanceTime;

            _repository.EditMovie(movie);
            return Result.Ok();
        }


    }
}
