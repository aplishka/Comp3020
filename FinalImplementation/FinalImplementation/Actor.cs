using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalImplementation
{
    class Actor
    {
        private string name;
        private List<Movie> movies;

        public Actor(string name)
        {
            this.name = name;
            this.movies = new List<Movie>();
        }

        public string GetName() { return this.name; }
        public int NumberOfMovies() { return this.movies.Count; }

        public void AddMovie(Movie movie)
        {
            this.movies.Add(movie);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
