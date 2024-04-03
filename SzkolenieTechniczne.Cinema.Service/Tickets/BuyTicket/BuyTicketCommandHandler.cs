using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;
using SzkolenieTechniczne.Cinema.Storage.Entities;

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

            var seance = movie.GetSeanceByDateAndRoomId(command.SeanceData);
            if (seance == null)
            {
                return Result.Fail("Seance does not exist. ");
            }

            var ticket = new Ticket(command.Email, command.NumberOfTickets);

            ticket.SeanceId = seance.Id;

            return Result.Ok();

        }

    }
}
