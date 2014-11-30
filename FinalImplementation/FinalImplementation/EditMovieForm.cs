﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalImplementation
{
    public partial class EditMovieForm : Form
    {
        private bool editFlag;
        private Movie movie;

        public EditMovieForm()
        {
            InitializeComponent();

            this.editFlag = false;
            this.Text = "Add new movie to database";
            this.formLabel.Text = "Add New Movie";

            SetupFormForAddingMovie();
        }

        public EditMovieForm(Movie movie)
        {
            InitializeComponent();

            this.editFlag = true;
            this.movie = movie;

            this.Text = "Edit \"" + movie.GetTitle() + "\"";

            LoadCurrentMovieDetails();
        }

        private void SetupFormForAddingMovie() 
        {
            this.deleteButton.Text = "Cancel";
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(this.editFlag)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.editFlag)
            {
                this.movie = SaveMovieDetails();
                this.Close();
            }
            else
            {
                Movie newMovie = SaveMovieDetails();

                WriteChangesToXML(newMovie);

                this.Close();
            }
        }

        private void WriteChangesToXML(Movie movie)
        {
            XDocument doc = XDocument.Load("../../../../movies.xml");
            XElement movieXElement = movie.ToXElement();
            doc.Root.Add(movieXElement);
            doc.Save("../../../../movies.xml");
        }

        // TODO: need to make sure that edits effect the main movies and actors lists
        // TODO: make sure that main page and junk is updated after editing or adding
        private Movie SaveMovieDetails()
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
                                    Int32.Parse(this.lengthTextBox.Text),
                                    this.directorTextBox.Text
                                    );
        }
    }
}