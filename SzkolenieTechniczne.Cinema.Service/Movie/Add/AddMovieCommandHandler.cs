using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Add
{
    internal class AddMovieCommandHandler : ICommandHandler<AddMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public AddMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(AddMovieCommand command)
        {
            var validationResult = new AddMovieCommandValidate().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var isExist = _repository.IsMovieExist(command.Name, command.Year);

            if (isExist) 
            {
                return Result.Fail("This movie already exist");
            }

            var movie = new Storage.Entities.Movie(command.Name, command.Year, command.SeanceTime, command.Description,0);
            _repository.AddMovie(movie);

            return Result.Ok();

            


        }

       
    }
}
