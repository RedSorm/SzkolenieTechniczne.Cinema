using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Seance
{
    internal class RegisterSeanceCommandValidate : AbstractValidator<RegisterSeanceCommand>
    {
        public RegisterSeanceCommandValidate()
        {
            RuleFor(x => x.MovieID).NotEmpty();
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Date).GreaterThan(DateTime.UtcNow);

        }

    }
}
