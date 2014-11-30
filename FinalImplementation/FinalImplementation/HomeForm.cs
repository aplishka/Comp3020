using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalImplementation
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            loadXML();
        }

        private void loadXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../../../movies.xml");

            XmlNode movieList = xml.DocumentElement.SelectSingleNode("/movielist");

            List<Movie> movies = new List<Movie>();
            List<Actor> actors = new List<Actor>();
            HashSet<string> genres = new HashSet<string>();

            foreach (XmlNode movie in movieList.ChildNodes)
            {
                List<Actor> currActors = new List<Actor>();
                List<string> currGenres = new List<string>();

                foreach (XmlNode actor in movie.SelectNodes("actor"))
                {
                    if (!actors.Exists(a => a.GetName() == actor.InnerText))
                    {
                        Actor newActor = new Actor(actor.InnerText);
                        actors.Add(newActor);
                        currActors.Add(newActor);
                    }
                    else
                    {
                        int index = actors.FindIndex(a => a.GetName() == actor.InnerText);
                        currActors.Add(actors.ElementAt(index));
                    }
                }

                foreach (XmlNode genre in movie.SelectNodes("genre"))
                {
                    currGenres.Add(genre.InnerText);
                    genres.Add(genre.InnerText);
                }

                Movie newMovie = new Movie(movie.SelectSingleNode("title").InnerText,
                                             Int32.Parse(movie.SelectSingleNode("year").InnerText),
                                             currActors,
                                             currGenres,
                                             movie.SelectSingleNode("certification") == null ? "" : movie.SelectSingleNode("certification").InnerText,
                                             Int32.Parse(movie.SelectSingleNode("rating").InnerText),
                                             Int32.Parse((movie.SelectSingleNode("length").InnerText.Split(' '))[0]),
                                             movie.SelectSingleNode("director").InnerText
                                             );

                movies.Add(newMovie);

                // Add movie to Actors credits
                foreach (Actor currActor in currActors)
                {
                    //int index = actors.FindIndex(a => a.GetName() == name);
                    currActor.AddMovie(newMovie);
                }
            }

                // Add movie titles to list
                topMoviesList.Items.AddRange(movies.ToArray());
                AddActorsToTopList(actors);

                // Add genres to UI
                topGenresList.Items.AddRange(genres.ToArray());
        }

        private void AddActorsToTopList(List<Actor> actors)
        {
            int threshold = 4;

            List<Actor> topActors = new List<Actor>();
            foreach (Actor actor in actors)
            {
                if (actor.NumberOfMovies() > threshold)
                {
                    topActors.Add(actor);
                }
            }

            // Add to UI
            topActorsList.Items.AddRange(topActors.ToArray());
        }

        private void searchData() 
        {
            SearchResultsForm form = new SearchResultsForm();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntryForm form = new DataEntryForm();
            form.ShowDialog();
        }

        private void topMoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm((Movie)topMoviesList.SelectedItem);
            form.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void topActorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm((Actor)topActorsList.SelectedItem);
            form.ShowDialog();
        }

        private void topGenresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] list = new string[2];

            list[0] = "<< Back";
            list[1] = "Some random movie..";

            topGenresList.Items.Clear();
            topGenresList.Items.AddRange(list);
        }
    }
}
