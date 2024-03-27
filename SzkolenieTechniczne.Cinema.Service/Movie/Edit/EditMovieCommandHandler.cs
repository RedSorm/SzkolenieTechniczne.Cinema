using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Command;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Movie.Edit
{
    internal class EditMovieCommandHandler: ICommandHandler<EditMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public EditMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

       /*
        public void Execute(EditMovieCommand command) 
        {
            
        }
       */

    }
}
