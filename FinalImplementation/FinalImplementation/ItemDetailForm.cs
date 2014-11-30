using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FinalImplementation
{
    public partial class ItemDetailForm : Form
    {
        private Movie movie;
        private Actor actor;

        public ItemDetailForm()
        {
            InitializeComponent();
        }

        public ItemDetailForm(Movie movie)
        {
            InitializeComponent();

            this.movie = movie;

            titleLabel.Text = movie.GetTitle() + " (" + movie.GetYear().ToString() + ")";
            this.Text = "Movie Detail Page";
            timeBox.Text = movie.GetMovieLength()+"min";
            directorBox.Text = movie.GetDirectorsName();
            certificationBox.Text = movie.GetCertification();
            genreBox.Items.AddRange(movie.GetGenres().ToArray());
            actorBox.Items.AddRange(movie.GetActors().ToArray());
            reviewBox.Items.AddRange(movie.GetReviews().ToArray());
            movieLabel.Visible = false;
            movieBox.Visible = false;
        }

        public ItemDetailForm(Actor actor)
        {
            InitializeComponent();

            this.actor = actor;

            titleLabel.Text = actor.GetName();
            this.Text = "Actor Detail Page";
            movieBox.Items.AddRange(actor.GetMovies().ToArray());
            timeBox.Visible = false;
            directorBox.Visible = false;
            certificationBox.Visible = false;
            genreBox.Visible = false;
            actorBox.Visible = false;
            timeLabel.Visible = false;
            directorBox.Visible = false;
            certificationLabel.Visible = false;
            genreLabel.Visible = false;
            actorLabel.Visible = false;
            stars.Visible = false;
            reviewBox.Visible = false;
            reviewButton.Visible = false;
            directorLabel.Visible = false;
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            ReviewForm form = new ReviewForm(movie);
            form.ShowDialog();

            // refresh reviews
            XmlDocument xml = new XmlDocument();
            xml.Load("../../../../movies.xml");
            XmlNode movieList = xml.DocumentElement.SelectSingleNode("/movielist");

            foreach (XmlNode mov in movieList.ChildNodes)
            {
                if (mov.SelectSingleNode("title").InnerText == this.movie.GetTitle())
                {
                    List<Actor> currActors = new List<Actor>();
                    List<string> currGenres = new List<string>();
                    List<Review> currReviews = new List<Review>();

                    foreach (XmlNode actor in mov.SelectNodes("actor"))
                    {
                        Actor newActor = new Actor(actor.InnerText);
                        currActors.Add(newActor);
                    }

                    foreach (XmlNode genre in mov.SelectNodes("genre"))
                    {
                        currGenres.Add(genre.InnerText);
                    }

                    foreach (XmlNode review in mov.SelectNodes("review"))
                    {
                        string[] splitOn = { "|break|" };
                        string[] arr = review.InnerText.Split(splitOn, System.StringSplitOptions.None);
                        currReviews.Add(new Review(Convert.ToInt32(arr[0]), arr[1], arr[2]));
                    }

                    Movie newMovie = new Movie(mov.SelectSingleNode("title").InnerText,
                                            Int32.Parse(mov.SelectSingleNode("year").InnerText),
                                            currActors,
                                            currGenres,
                                            mov.SelectSingleNode("certification") == null ? "" : mov.SelectSingleNode("certification").InnerText,
                                            Int32.Parse(mov.SelectSingleNode("rating").InnerText),
                                            Int32.Parse((mov.SelectSingleNode("length").InnerText.Split(' '))[0]),
                                            mov.SelectSingleNode("director").InnerText,
                                            currReviews
                                            );
                    this.movie = newMovie;
                }
            }
            reviewBox.Items.Clear();

            reviewBox.Items.AddRange(this.movie.GetReviews().ToArray());
        }

        private void editMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovieForm form = new EditMovieForm(this.movie);
            form.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actor temp = new Actor();
            if (actorBox.SelectedItem != null && actorBox.SelectedItem.GetType() == temp.GetType())
            {
                ItemDetailForm form = new ItemDetailForm((Actor)actorBox.SelectedItem);
                form.ShowDialog();
            }
        }

        private void movieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie temp = new Movie();
            if (movieBox.SelectedItem != null && movieBox.SelectedItem.GetType() == temp.GetType())
            {
                ItemDetailForm form = new ItemDetailForm((Movie)movieBox.SelectedItem);
                form.ShowDialog();
            }
        }
    }
}
