using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalImplementation
{
    public class Movie
    {
        private string title;
        private int year;
        private List<Actor> actors;
        private List<string> genres;
        private List<Review> reviews;
        private string certification;
        private int rating;
        private int time;
        private string director;

        public Movie(string title, int year, List<Actor> actors, List<string> genres, string certification,
            int rating, int time, string director, List<Review> _reviews)
        {
            this.title = title;
            this.year = year;
            this.actors = actors;
            this.genres = genres;
            this.certification = certification;
            this.rating = rating;
            this.time = time;
            this.director = director;
            this.reviews = _reviews;
        }

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
            this.reviews = new List<Review>();
        }

        public Movie()
        {
            this.title = "";
            this.year = -1;
            this.actors = null;
            this.genres = null;
            this.reviews = null;
            this.certification = "";
            this.rating = -1;
            this.time = -1;
            this.director = "";
        }

        public string GetTitle() { return this.title; }
        public int GetYear() { return this.year;  }
        public int GetRating() { return this.rating;  }
        public List<string> GetActorNames()
        {
            List<string> results = new List<string>();
            for(int x=0; x<actors.Count; x++)
            {
                results.Add(actors[x].GetName().ToLower());
            }
            return results;
        }
        public List<string> GetGenres() { return this.genres; }
        public List<Actor> GetActors() { return this.actors; }
        public List<Review> GetReviews() { return this.reviews; }
        public string GetCertification() { return this.certification; }
        public int GetMovieLength() { return this.time; }
        public string GetDirectorsName() { return this.director; }
        public void AddReview(Review _review) { this.reviews.Add(_review); }

        public override string ToString()
        {
            return this.title + " (" + this.year.ToString() + ")";
        }

        public XElement ToXElement()
        {
            XElement movieXElement = new XElement("movie",
                new XElement("title", this.title),
                new XElement("year", this.year),
                new XElement("certification", this.certification),
                new XElement("rating", this.rating),
                new XElement("length", this.time),
                new XElement("director", this.director)
                );

            foreach(Actor actor in this.actors) 
            {
                movieXElement.Add(new XElement("actor", actor.GetName()));
            }

            foreach (string genre in this.genres)
            {
                movieXElement.Add(new XElement("genre", genre));
            }

            foreach (Review review in this.reviews)
            {
                movieXElement.Add(new XElement("review", review.GetRating()+"|break|"+review.GetPlot()+"|break|"+review.GetActor()));
            }

            return movieXElement;
        }

        public int CompareTo(Movie other)
        {
            if (this.year == other.GetYear())
            {
                return this.title.CompareTo(other.GetTitle());
            }
            return this.year.CompareTo(other.GetYear());
        }
    }
}
