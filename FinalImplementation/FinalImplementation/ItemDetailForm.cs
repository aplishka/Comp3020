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
            addToListButton.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            ReviewForm form = new ReviewForm();
            form.ShowDialog();
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

        private void addToListButton_Click(object sender, EventArgs e)
        {
            AddMovieToUserListForm form = new AddMovieToUserListForm(this.movie);
            form.ShowDialog();
        }
    }
}
