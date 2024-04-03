using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;

namespace SzkolenieTechniczne.Cinema.Service.Tickets.BuyTicket
{
    public sealed class BuyTicketCommand : ICommand
    {
        public long MovieID { get; set; }

        public long Ticket { get; set; }

        public DateTime Date { get; set; }

        public long NumberOfTickets { get; set; }

        public long Email   { get; set; }
      
    }
}
