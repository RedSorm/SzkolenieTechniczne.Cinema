using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Seance
{
    public sealed class RegisterSeanceCommand : ICommand
    {
        public long MovieID { get; set; }

        public DateTime Date { get; set; }


    }
}
