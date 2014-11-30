using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalImplementation
{
    class Movie
    {
        private string title;
        private int year;
        private List<Actor> actors;
        private List<string> genres;
        private string certification;
        private int rating;
        private int time;
        private string director;

        public Movie(string title, int year, List<Actor> actors, List<string> genres, string certification,
            int rating, int time, string director)
        {
            this.title = title;
            this.year = year;
            this.actors = actors;
            this.genres = genres;
            this.certification = certification;
            this.rating = rating;
            this.time = time;
            this.director = director;
        }

        public string GetTitle() { return this.title; }
        public int GetYear() { return this.year;  }

        public override string ToString()
        {
            return this.title + " (" + this.year.ToString() + ")";
        }
    }
}
