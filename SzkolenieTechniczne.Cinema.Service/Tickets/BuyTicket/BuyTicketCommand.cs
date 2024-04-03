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

        public BuyTicketCommand(long movieId, DateTime seanceData, string email, int numberOfTickets)
        {
            SeanceData = seanceData;

            Email = email;

            NumberOfTickets = numberOfTickets;

            MovieID =movieId;
        }
        public long MovieID { get; set; }

        

        public DateTime SeanceData { get; set; }

        public int NumberOfTickets { get; set; }

        public string Email   { get; set; }

              
    }
}
