using System;
namespace SzkolenieTechniczne.Cinema.Service.Query
{
    public class MovieDto
    {
        public string Name { get; set; }

        public long Id { get; set; }

        public MovieDto(string name, long id)
        {
            Name = name;
            Id = id;
        }
    }
}
