using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalImplementation
{
    public partial class HomeForm : Form
    {
        private List<Movie> movies = new List<Movie>();
        private List<Actor> actors = new List<Actor>();
        private HashSet<string> genres = new HashSet<string>();
        private string genreState = "genre";
        private string decadeState = "decade";
        private const int EM_SETCUEBANNER = 0x1501;
        private string[] decades = {"1900s","1910s","1920s","1930s","1940s","1950s","1960s","1970s","1980s","1990s","2000s","2010s"};
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public HomeForm()
        {
            InitializeComponent();
            loadData();
            SendMessage(searchTextBox.Handle, EM_SETCUEBANNER, 0, "Enter Search Query...");
        }

        private void loadData()
        {
            loadXML();
            setDecades();
        }

        private void loadXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../../../movies.xml");

            XmlNode movieList = xml.DocumentElement.SelectSingleNode("/movielist");

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
            List<Movie> topMovies = new List<Movie>();
            for (int x = 0; x < movies.Count; x++)
            {
                if (movies[x].GetRating() >= 9)
                {
                    topMovies.Add(movies[x]);
                }
            }
            topMoviesList.Items.AddRange(topMovies.ToArray());

            // Add actor titles to list
            List<Actor> topActors = new List<Actor>();
            for (int x = 0; x < actors.Count; x++)
            {
                Boolean found = false;
                for (int y = 0; y < topMovies.Count; y++)
                {
                    if (topMovies[y].GetActors().Contains(actors[x]))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    topActors.Add(actors[x]);
                }
            }

            AddActorsToTopList(topActors);

            // Add genres to UI
            topGenresList.Items.AddRange(genres.ToArray());
        }

        private void setDecades()
        {
            topDecadesList.Items.AddRange(decades);
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
            if (searchTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter text in the search box..",
                                    "Invalid Search",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                SearchResultsForm form = new SearchResultsForm(searchTextBox.Text);
                form.ShowDialog();
            }
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
            if (genreState == "genre")
            {
                string selected = (string)topGenresList.SelectedItem;
                topGenresList.Items.Clear();
                topGenresList.Items.Add("<< Back");
                for (int x = 0; x < movies.Count; x++)
                {
                    if (movies[x].GetGenres().Contains(selected))
                    {
                        topGenresList.Items.Add(movies[x]);
                    }
                }
                genreState = "movies";
            }
            else if (genreState == "movies")
            {
                if (topGenresList.SelectedItem.GetType() == "".GetType())
                {
                    topGenresList.Items.Clear();
                    topGenresList.Items.AddRange(genres.ToArray());
                    genreState = "genre";
                }
                else
                {
                    ItemDetailForm form = new ItemDetailForm((Movie)topGenresList.SelectedItem);
                    form.ShowDialog();
                }
            }
        }

        private void topDecadesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (decadeState == "decade")
            {
                string selected = (string)topDecadesList.SelectedItem;
                int currDec = Convert.ToInt32(selected.Substring(0,4));
                topDecadesList.Items.Clear();
                topDecadesList.Items.Add("<< Back");
                for (int x = 0; x < movies.Count; x++)
                {
                    if (movies[x].GetYear() >= currDec && movies[x].GetYear() <= currDec+9)
                    {
                        topDecadesList.Items.Add(movies[x]);
                    }
                }
                decadeState = "movies";
            }
            else if (decadeState == "movies")
            {
                if (topDecadesList.SelectedItem.GetType() == "".GetType())
                {
                    topDecadesList.Items.Clear();
                    topDecadesList.Items.AddRange(decades);
                    decadeState = "decade";
                }
                else
                {
                    ItemDetailForm form = new ItemDetailForm((Movie)topDecadesList.SelectedItem);
                    form.ShowDialog();
                }
            }
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovieForm form = new AddMovieForm();
            form.ShowDialog();
        }
    }
}
