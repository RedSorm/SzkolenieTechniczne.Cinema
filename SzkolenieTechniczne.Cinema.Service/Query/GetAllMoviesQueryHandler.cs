using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Query
{
    internal class GetAllMoviesQueryHandler : IQueryHandler<GetAllMoviesQuery, List<MovieDto>>
    {
        private readonly IMovieRepository _repository;

        public GetAllMoviesQueryHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public List<MovieDto> Handle(GetAllMoviesQuery query)
        {
            var movies = _repository.GetMovies();

            return movies.Select(item => new MovieDto(item.Name,item.Id)).ToList(); 

        }


    }
}
