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
    public partial class VisualSearchForm : Form
    {
        private List<Movie> currMovies = new List<Movie>();
        private string currGenre = "All";
        private string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", 
                                       "s", "t", "u" ,"v","w","x","y","z"};
        private List<Movie> movies = new List<Movie>();
        private List<Actor> actors = new List<Actor>();
        HashSet<string> genres = new HashSet<string>();
        private Color[] colors = {Color.YellowGreen,Color.Yellow,Color.DarkViolet,Color.DarkSeaGreen,Color.DarkSlateBlue,Color.Violet,
                                    Color.Turquoise,Color.Tomato,Color.Thistle,Color.Teal,Color.Tan,Color.SteelBlue,
                                    Color.SpringGreen,Color.DeepPink,Color.DodgerBlue,Color.SlateBlue,Color.SkyBlue,Color.Silver,
                                    Color.Sienna,Color.Gray,Color.Goldenrod,Color.Fuchsia,Color.Aqua,Color.Gold,
                                    Color.ForestGreen,Color.Firebrick,Color.Black};
        public VisualSearchForm()
        {
            InitializeComponent();
            loadXML();
            addMovies();
        }

        private void addMovies()
        {
            int count = 0;
            int minYear = minYearSlider.Value;
            int maxYear = maxYearSlider.Value;
            int minRate = minStarSlider.Value;
            int maxRate = maxStarSlider.Value;
            int xjump;
            int yjump;
            Random rnd = new Random();

            loadingPanel.Visible = true;
            loadingPanel.Update();

            if (maxYear - minYear + 1 != 0) { xjump = (graphBox.Width) / (maxYear - minYear + 1); }
            else { xjump = 0; }
            if (maxRate - minRate + 1 != 0) { yjump = (graphBox.Height) / (maxRate - minRate + 1); }
            else { yjump = 0; }
            currMovies = new List<Movie>();

            List<Movie> fmovies = filterMovies();

            for (int i = graphBox.Controls.Count - 1; i >= 0; i--)
                graphBox.Controls[i].Dispose();

            for (int x = 0; x < fmovies.Count; x++)
            {
                if (fmovies[x].GetRating() >= minRate && fmovies[x].GetRating() <= maxRate &&
                    fmovies[x].GetYear() >= minYear && fmovies[x].GetYear() <= maxYear)
                {
                    Button toAdd = new Button();
                    if (maxYear - minYear + 3 != 0) { toAdd.Width = (graphBox.Width) / (maxYear - minYear + 3); }
                    else { toAdd.Width = 0; }
                    if (maxRate - minRate + 3 != 0) { toAdd.Height = (graphBox.Height) / (maxRate - minRate + 3); }
                    else { toAdd.Height = 0; }
                    toAdd.Left = (xjump * (fmovies[x].GetYear() - minYear)) + rnd.Next(0,15);
                    toAdd.Top = (yjump * (fmovies[x].GetRating() - minRate)) + rnd.Next(0,15);
                    int index = 0;
                    for (int y = 0; y < genres.Count; y++) { if (fmovies[x].GetGenres().Contains(genres.ToArray()[y])) { index = y; } }
                    toAdd.BackColor = colors[index];
                    toAdd.Name = count+"";
                    toAdd.Click += new EventHandler(movieClick);
                    currMovies.Add(fmovies[x]);
                    graphBox.Controls.Add(toAdd);
                    count = count + 1;
                }
            }
            filmCountLabel.Text = count + "";

            loadingPanel.Visible = false;
        }

        private List<Movie> filterMovies()
        {
            List<Movie> result = new List<Movie>();

            foreach(Movie movie in movies)
            {
                if(movie.GetMovieLength() >= lengthMinSlider.Value &&
                    movie.GetMovieLength() <= lengthMaxSlider.Value)
                {
                    if(currGenre == "All" || movie.GetGenres().Contains(currGenre))
                    {
                        Boolean add = true;

                        if (actorSlider.Value > 0)
                        {
                            Boolean found = false;
                            foreach (string actor in movie.GetActorNames())
                            {
                                if (actor.ToLower().StartsWith(letters[actorSlider.Value-1])) { found = true; }
                            }
                            if (!found) { add = false; }
                        }

                        if (directorSlider.Value > 0)
                        {
                            if (!(movie.GetDirectorsName().ToLower().StartsWith(letters[directorSlider.Value-1]))) { add = false; }
                        }

                        if (titleSlider.Value > 0)
                        {
                            if (!(movie.GetTitle().ToLower().StartsWith(letters[titleSlider.Value-1]))) { add = false; }
                        }

                        if (add && (gRating.Checked || pgRating.Checked || pg13Rating.Checked || rRating.Checked))
                        {
                            add = false;

                            if (gRating.Checked == true)
                            {
                                if ((movie.GetCertification() == "G")) { add = true; }
                            }

                            if (pgRating.Checked == true)
                            {
                                if ((movie.GetCertification() == "PG")) { add = true; }
                            }

                            if (pg13Rating.Checked == true)
                            {
                                if ((movie.GetCertification() == "PG-13")) { add = true; }
                            }

                            if (rRating.Checked == true)
                            {
                                if ((movie.GetCertification() == "R")) { add = true; }
                            }

                            if (add) { result.Add(movie); }
                        }
                        else
                        {
                            if (add) { result.Add(movie); }
                        }
                    }
                }
            }

            return result;
        }

        private void minYearSlider_Scroll(object sender, EventArgs e)
        {
            if (minYearSlider.Value <= maxYearSlider.Value)
            {
                minYearLabel.Text = minYearSlider.Value + "";
            }
            else
            {
                minYearSlider.Value = maxYearSlider.Value;
            }
            addMovies();
        }

        private void maxYearSlider_Scroll(object sender, EventArgs e)
        {
            if (maxYearSlider.Value >= minYearSlider.Value)
            {
                maxYearLabel.Text = maxYearSlider.Value + "";
            }
            else
            {
                maxYearSlider.Value = minYearSlider.Value;
            }
            addMovies();
        }

        private void minStarSlider_Scroll(object sender, EventArgs e)
        {
            if (minStarSlider.Value <= maxStarSlider.Value)
            {
                minStarLabel.Text = minStarSlider.Value + "";
            }
            else
            {
                minStarSlider.Value = maxStarSlider.Value;
            }
            addMovies();
        }

        private void maxStarSlider_Scroll(object sender, EventArgs e)
        {
            if (maxStarSlider.Value >= minStarSlider.Value)
            {
                maxStarLabel.Text = maxStarSlider.Value + "";
            }
            else
            {
                maxStarSlider.Value = minStarSlider.Value;
            }
            addMovies();
        }

        private void lengthMinSlider_Scroll(object sender, EventArgs e)
        {
            if (lengthMinSlider.Value <= lengthMaxSlider.Value)
            {
                lengthMinLabel.Text = lengthMinSlider.Value + "";
            }
            else
            {
                lengthMinSlider.Value = lengthMaxSlider.Value;
            }
            addMovies();
        }

        private void lengthMaxSlider_Scroll(object sender, EventArgs e)
        {
            if (lengthMaxSlider.Value >= lengthMinSlider.Value)
            {
                lengthMaxLabel.Text = lengthMaxSlider.Value + "";
            }
            else
            {
                lengthMaxSlider.Value = lengthMinSlider.Value;
            }
            addMovies();
        }

        protected void movieClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int index = Convert.ToInt32(button.Name);
            ItemDetailForm form = new ItemDetailForm(currMovies[index]);
            form.ShowDialog();
            loadingPanel.Visible = true;
            loadingPanel.Update();
            loadXML();
            addMovies();
            loadingPanel.Visible = false;
        }

        private void loadXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../../../movies.xml");

            XmlNode movieList = xml.DocumentElement.SelectSingleNode("/movielist");
            genres.Add("All");

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
                    string[] splitOn = { "|break|" };
                    string[] arr = review.InnerText.Split(splitOn, System.StringSplitOptions.None);
                    currReviews.Add(new Review(Convert.ToInt32(arr[0]), arr[1], arr[2]));
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

            // Add genres to UI
            genreSelector.Items.Clear();
            string[] genres_to_add = genres.ToArray();
            Array.Sort(genres_to_add);
            genreSelector.Items.AddRange(genres_to_add);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genreSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currGenre = (string)genreSelector.SelectedItem;
            addMovies();
        }

        private void gRating_CheckedChanged(object sender, EventArgs e)
        {
            addMovies();
        }

        private void pg13Rating_CheckedChanged(object sender, EventArgs e)
        {
            addMovies();
        }

        private void pgRating_CheckedChanged(object sender, EventArgs e)
        {
            addMovies();
        }

        private void rRating_CheckedChanged(object sender, EventArgs e)
        {
            addMovies();
        }

        private void actorSlider_Scroll(object sender, EventArgs e)
        {
            addMovies();
        }

        private void titleSlider_Scroll(object sender, EventArgs e)
        {
            addMovies();
        }

        private void directorSlider_Scroll(object sender, EventArgs e)
        {
            addMovies();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovieForm form = new AddMovieForm();
            form.ShowDialog();
            loadingPanel.Visible = true;
            loadingPanel.Update();
            loadXML();
            addMovies();
            loadingPanel.Visible = false;
        }

        private void genreSelector_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string text = ((ComboBox)sender).Items[e.Index].ToString();  
            Brush brush = new SolidBrush(colors[e.Index]); 
            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }
    }
}
