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
            movies = new List<Movie>();
            actors = new List<Actor>();
            genres = new HashSet<string>();

            foreach (XmlNode movie in movieList.ChildNodes)
            {
                List<Actor> currActors = new List<Actor>();
                List<string> currGenres = new List<string>();
                List<Review> currReviews = new List<Review>();

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

                foreach (XmlNode review in movie.SelectNodes("review"))
                {
                    string[] splitOn = {"|break|"};
                    string[] arr = review.InnerText.Split(splitOn,System.StringSplitOptions.None);
                    currReviews.Add(new Review(Convert.ToInt32(arr[0]),arr[1],arr[2]));
                }

                Movie newMovie = new Movie(movie.SelectSingleNode("title").InnerText,
                                             Int32.Parse(movie.SelectSingleNode("year").InnerText),
                                             currActors,
                                             currGenres,
                                             movie.SelectSingleNode("certification") == null ? "" : movie.SelectSingleNode("certification").InnerText,
                                             Int32.Parse(movie.SelectSingleNode("rating").InnerText),
                                             Int32.Parse((movie.SelectSingleNode("length").InnerText.Split(' '))[0]),
                                            movie.SelectSingleNode("director").InnerText,
                                            currReviews
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
            loadingPanel.Visible = true;
            loadingPanel.Update();
            SearchResultsForm form = new SearchResultsForm(searchTextBox.Text);
            form.ShowDialog();
            reloadPage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topMoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm((Movie)topMoviesList.SelectedItem);
            form.ShowDialog();
            reloadPage();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void topActorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm((Actor)topActorsList.SelectedItem);
            form.ShowDialog();
            reloadPage();
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
                    reloadPage();
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
                    loadingPanel.Update();
                    reloadPage();
                }
            }
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovieForm form = new AddMovieForm();
            form.ShowDialog();
            reloadPage();
        }

        private void userListsButton_Click(object sender, EventArgs e)
        {
            UserListsForm form = new UserListsForm(this.actors);
            form.ShowDialog();
            reloadPage();
        }

        private void reloadPage()
        {
            loadingPanel.Visible = true;
            loadingPanel.Update();
            topMoviesList.Items.Clear();
            topActorsList.Items.Clear();
            topGenresList.Items.Clear();
            topDecadesList.Items.Clear();
            loadData();
            loadingPanel.Visible = false;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            loadingPanel.Update();
            VisualSearchForm form = new VisualSearchForm();
            form.ShowDialog();
            reloadPage();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
