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
        private string state;

        public ReviewForm(Movie movie, string state, Review review)
        {
            InitializeComponent();
            this.Movie = movie;
            this.state = state;

            if (state == "view")
            {
                plotReview.ReadOnly = true;
                actorsReview.ReadOnly = true;
                PublishReviewButton.Text = "Close";
                starRating.Visible = false;
                ratingBar.Value = review.GetRating();
                plotReview.Text = review.GetPlot();
                actorsReview.Text = review.GetActor();
                ratingLabel.Text = review.GetRating() + "/10";
            }
            else
            {
                ratingBar.Visible = false;
                ratingLabel.Visible = false;
            }
        }

        private void PublishReviewButton_Click(object sender, EventArgs e)
        {
            if (state == "edit")
            {
                if (validateFields())
                {
                    Review review = new Review(starRating.SelectedStar, plotReview.Text, actorsReview.Text);
                    WriteChangesToXML(review);
                }
            }
            else
            {
                this.Close();
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
