using System;
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
    public partial class AddMovieForm : FinalImplementation.EditMovieForm
    {
        public AddMovieForm()
        {
            InitializeComponent();

            SetupFormForAddingMovie();
        }

        private void SetupFormForAddingMovie()
        {
            this.deleteButton.Text = "Cancel";
        }

        protected override void deleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void saveButton_Click(object sender, EventArgs e)
        {
            Movie newMovie = SaveMovieDetails();
            WriteChangesToXML(newMovie);
            this.Close();
        }
    }
}
