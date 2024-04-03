using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;
using SzkolenieTechniczne.Cinema.Service.Movie.Edit;

namespace SzkolenieTechniczne.Cinema.Service.Tickets.BuyTicket
{
    internal class BuyTicketCommandHandler : ICommandHandler<BuyTicketCommand>
    {
        private readonly IMovieRepository _repository;

        public BuyTicketCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(BuyTicketCommand command)
        {
            var validationResult = new BuyTicketCommandValidate().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var movie = _repository.GetMovieById(command.MovieID);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist");
            }

            var isSeanceExist = _repository.IsSeanceExist(command.Date);
            if (isSeanceExist == false)
            {
                return Result.Fail("This seance does not  exsit. ");
            }

            var isEmailExsit = _repository.IsMovieExist(command.Email);
            if (isEmailExsit == false)
            {
                return Result.Fail("Email does not exsit. ");
            }
           
            










            return Result.Ok();
        }

    }
}
