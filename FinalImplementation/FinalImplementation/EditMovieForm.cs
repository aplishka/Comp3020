using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;

namespace FinalImplementation
{
    public partial class EditMovieForm : Form
    {
        private Movie movie;

        public EditMovieForm()
        {
            InitializeComponent();
        }

        public EditMovieForm(Movie movie)
        {
            InitializeComponent();

            this.movie = movie;
            this.Text = "Edit \"" + movie.GetTitle() + "\"";

            LoadCurrentMovieDetails();
        }

        private void LoadCurrentMovieDetails()
        {
            this.titleTextBox.Text = this.movie.GetTitle();
            this.yearTextBox.Text = this.movie.GetYear().ToString();
            this.certificationTextBox.Text = this.movie.GetCertification();
            this.directorTextBox.Text = this.movie.GetDirectorsName();
            this.lengthTextBox.Text = this.movie.GetMovieLength().ToString() + " min";

            string actorsString = "";
            foreach (Actor actor in this.movie.GetActors())
            {
                actorsString += actor.ToString() + "\n";
            }
            this.actorsTextBox.Text = actorsString;

            string genresString = "";
            foreach (string genre in this.movie.GetGenres())
            {
                genresString += genre + "\n";
            }
            this.genresTextBox.Text = genresString;
        }

        protected virtual void deleteButton_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("../../../../movies.xml");
            XElement element = doc.Root.Descendants("movie").SingleOrDefault(m => (string)m.Element("title") == this.movie.GetTitle());

            if (element != null)
            {
                element.Remove();
                doc.Save("../../../../movies.xml");
            }            

            this.Close();
        }

        protected bool ValidateMovieFields()
        {
            bool allFieldsValid = true;

            if (string.IsNullOrWhiteSpace(this.titleTextBox.Text))
            {
                errorProvider1.SetError(this.titleTextBox, "Title is a required field");
                allFieldsValid = false;
            }

            Match match = Regex.Match(this.yearTextBox.Text, @"\d{4}");
            if (string.IsNullOrWhiteSpace(this.yearTextBox.Text) || !match.Success)
            {
                errorProvider1.SetError(this.yearTextBox, "Year is a required field, and must be of the format ####");
                allFieldsValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.directorTextBox.Text))
            {
                errorProvider1.SetError(this.directorTextBox, "Director is a required field");
                allFieldsValid = false;
            }

            match = Regex.Match(this.lengthTextBox.Text, @"\d{2,4} min");
            if (string.IsNullOrWhiteSpace(this.lengthTextBox.Text) || !match.Success)
            {
                errorProvider1.SetError(this.lengthTextBox, "Length is a required field, and should be of the format '## min'");
                allFieldsValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.actorsTextBox.Text))
            {
                errorProvider1.SetError(this.actorsTextBox, "Must be at least one actor in film");
                allFieldsValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.genresTextBox.Text))
            {
                errorProvider1.SetError(this.genresTextBox, "Film must have at least one genre");
                allFieldsValid = false;
            }

            return allFieldsValid;
        }

        protected virtual void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateMovieFields())
            {
                string oldTitle = this.movie.GetTitle();
                this.movie = SaveMovieDetails();

                XDocument doc = XDocument.Load("../../../../movies.xml");
                XElement element = doc.Root.Descendants("movie").SingleOrDefault(m => (string)m.Element("title") == oldTitle);

                element.ReplaceAll(this.movie.ToXElement());
                doc.Save("../../../../movies.xml");

                this.Close();
            }
        }

        protected void WriteChangesToXML(Movie movie)
        {
            XDocument doc = XDocument.Load("../../../../movies.xml");
            XElement movieXElement = movie.ToXElement();
            doc.Root.Add(movieXElement);
            doc.Save("../../../../movies.xml");
        }

        // TODO: need to make sure that edits effect the main movies and actors lists
        // TODO: make sure that main page and junk is updated after editing or adding
        protected Movie SaveMovieDetails()
        {
            List<Actor> actors = new List<Actor>();
            string[] actorStrings = this.actorsTextBox.Text.Split('\n');
            foreach (string actor in actorStrings)
            {
                // TODO: Need to check and combine these actors with the definitive actors list
                actors.Add(new Actor(actor));
            }

            List<string> genres = new List<string>();
            string[] genreStrings = this.genresTextBox.Text.Split('\n');
            foreach (string genre in genreStrings)
            {
                genres.Add(genre);
            }

            return new Movie(this.titleTextBox.Text,
                                    Int32.Parse(this.yearTextBox.Text),
                                    actors,
                                    genres,
                                    this.certificationTextBox.Text,
                                    this.starRatingControl1.SelectedStar,
                                    Int32.Parse(this.lengthTextBox.Text.Split(' ')[0]),
                                    this.directorTextBox.Text,
                                    this.movie.GetReviews()
                                    );
        }
    }
}
