using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;

namespace SzkolenieTechniczne.Cinema.Service.Tickets.BuyTicket
{
    internal class BuyTicketCommandValidate: AbstractValidator<BuyTicketCommand>
    {
        public BuyTicketCommandValidate()
        {
            RuleFor(x => x.MovieID).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.NumberOfTickets).GreaterThan(0); 
            RuleFor(x => x.Ticket).NotEmpty();
            RuleFor(x => x.Date).GreaterThan(DateTime.UtcNow);
        }
    }
}
