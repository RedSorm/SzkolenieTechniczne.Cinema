using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Seance
{
    internal class RegisterSeanceCommandHandler : ICommandHandler<RegisterSeanceCommand>
    {
        private readonly IMovieRepository _repository;

        public RegisterSeanceCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(RegisterSeanceCommand command)
        {
            var validationResult = new RegisterSeanceCommandValidate().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var isSeanceExist = _repository.IsSeanceExist(command.Date);
            if (isSeanceExist == false)
            {
                return Result.Fail("This seance already exsit. ");
            }

            var movie = _repository.GetMovieById(command.MovieID);
            if (movie == null)
            {
                return Result.Fail("This movie does not exist. ");
            }

            var seance = new Cinema.Storage.Entities.Seance(command.Date, command.MovieID);

            movie.Seances.Add(seance);


            return Result.Ok();


        }
    }
}
