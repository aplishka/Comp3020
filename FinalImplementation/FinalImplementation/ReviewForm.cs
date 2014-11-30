using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RatingControls;
using System.Xml.Linq;

namespace FinalImplementation
{
    public partial class ReviewForm : Form
    {
        private Movie Movie;

        public ReviewForm(Movie movie)
        {
            InitializeComponent();
            this.Movie = movie;
        }

        private void PublishReviewButton_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                Review review = new Review(starRating.SelectedStar, plotReview.Text, actorsReview.Text);
                WriteChangesToXML(review);
            }
        }

        private Boolean validateFields()
        {
            Boolean result = true;

            if (starRating.SelectedStar == 0)
            {
                errorText.Text = "* Please enter a star rating before publishing.";
                result = false;
            }

            return result;
        }

        private void WriteChangesToXML(Review review)
        {
            this.Movie.AddReview(review);

            XDocument doc = XDocument.Load("../../../../movies.xml");
            XElement element = doc.Root.Descendants("movie").SingleOrDefault(m => (string)m.Element("title") == Movie.GetTitle());

            element.ReplaceWith(this.Movie.ToXElement());//(.ReplaceAll(this.Movie.ToXElement());
            //doc.Root.Add(this.Movie.ToXElement());
            doc.Save("../../../../movies.xml");

            this.Close();
        }
    }
}
