using System;
using System.Collections.Generic;
using SzkolenieTechniczne.Cinema.Storage.Entities;

namespace SzkolenieTechniczne.Cinema.Storage.Repository
{
    public interface IMovieRepository
    {

        List<Entities.Movie> GetMovies();
        Entities.Movie GetMovieById(long MovieId);


        void AddMovie(Entities.Movie movie);
        void EditMovie(Entities.Movie movie);
        void RemoveMovie(long id);
        bool IsMovieExist(long id);
        bool IsMovieExist(string name, int year);
        bool IsSeanceExist(DateTime date);
        
        void AddSeance(Entities.Seance seance);

        List<Seance> GetSeancesByMovieId(long movieId);
        Entities.Movie GetSeanceDetails(long movieId);
    }
}
