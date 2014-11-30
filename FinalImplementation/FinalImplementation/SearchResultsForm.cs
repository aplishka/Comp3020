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
    public partial class SearchResultsForm : Form
    {
        private List<Movie> movies = new List<Movie>();
        private List<Actor> actors = new List<Actor>();
        private string searchString = "";
        public SearchResultsForm(string _searchstring)
        {
            InitializeComponent();
            toolTip1.SetToolTip(plus1, "Add another actor to search on");
            toolTip1.SetToolTip(plus2, "Add another actor to search on");
            toolTip1.SetToolTip(plus3, "Add another actor to search on");
            toolTip1.SetToolTip(minus2, "Remove this actor from search");
            toolTip1.SetToolTip(minus3, "Remove this actor from search");
            toolTip1.SetToolTip(minus4, "Remove this actor from search");
            toolTip1.SetToolTip(backButton, "Back To Home Page");
            searchTextBox.Text = _searchstring;
            this.searchString = _searchstring;
            loadXML();
            searchForString();
        }

        private void searchForString()
        {
            List<Movie> mResults = new List<Movie>();;
            List<Actor> aResults = new List<Actor>(); ;

            searchResultList.Items.Clear();

            for (int x = 0; x < movies.Count; x++)
            {
                if (movies[x].GetTitle().ToLower().Contains(searchString.ToLower()))
                {
                    mResults.Add(movies[x]);
                }
            }

            for (int x = 0; x < actors.Count; x++)
            {
                if (actors[x].GetName().ToLower().Contains(searchString.ToLower()))
                {
                    aResults.Add(actors[x]);
                }
            }

            if (mResults.Count > 0) 
            { 
                searchResultList.Items.Add("Movies:");
                searchResultList.Items.Add(" "); 
            }
            searchResultList.Items.AddRange(mResults.ToArray());
            if (aResults.Count > 0) 
            {
                searchResultList.Items.Add(" "); 
                searchResultList.Items.Add("Actors:");
                searchResultList.Items.Add(" "); 
            }
            searchResultList.Items.AddRange(aResults.ToArray());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            plus1.Visible = false;
            minus1.Visible = false;
            actor2.Visible = true;
            plus2.Visible = true;
            minus2.Visible = true;
        }

        private void plus2_Click(object sender, EventArgs e)
        {
            plus2.Visible = false;
            minus2.Visible = false;
            actor3.Visible = true;
            plus3.Visible = true;
            minus3.Visible = true;
        }

        private void plus3_Click(object sender, EventArgs e)
        {
            plus3.Visible = false;
            minus3.Visible = false;
            actor4.Visible = true;
            minus4.Visible = true;
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            actor1.Text = "";
        }

        private void minus2_Click(object sender, EventArgs e)
        {
            actor2.Text = "";
            actor2.Visible = false;
            plus2.Visible = false;
            minus2.Visible = false;
            plus1.Visible = true;
            minus1.Visible = true;
        }

        private void minus3_Click(object sender, EventArgs e)
        {
            actor3.Text = "";
            actor3.Visible = false;
            plus3.Visible = false;
            minus3.Visible = false;
            plus2.Visible = true;
            minus2.Visible = true;
        }

        private void minus4_Click(object sender, EventArgs e)
        {
            actor4.Text = "";
            actor4.Visible = false;
            minus4.Visible = false;
            plus3.Visible = true;
            minus3.Visible = true;
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            var fromCount = starRatingFrom.SelectedStar;
            var toCount = starRatingTo.SelectedStar;
            var genre = genreSelector.SelectedItem;
            var dateFrom = fromSlider.Value;
            var dateTo = toSlider.Value;
            string[] actorSearch = new string[4];
            if (actor1.Visible == true && actor1.Text.Length > 0) { actorSearch[0] = actor1.Text; }
            if (actor2.Visible == true && actor2.Text.Length > 0) { actorSearch[1] = actor2.Text; }
            if (actor3.Visible == true && actor3.Text.Length > 0) { actorSearch[2] = actor3.Text; }
            if (actor4.Visible == true && actor4.Text.Length > 0) { actorSearch[3] = actor4.Text; }
            List<Movie> mResults = new List<Movie>();
            List<Movie> mResultsAdv = new List<Movie>();
            List<Actor> aResults = new List<Actor>();

            searchResultList.Items.Clear();

            for (int x = 0; x < movies.Count; x++)
            {
                if (movies[x].GetTitle().ToLower().Contains(searchString.ToLower()))
                {
                    mResults.Add(movies[x]);
                }
            }

            for (int x = 0; x < mResults.Count; x++)
            {
                if (mResults[x].GetYear() >= dateFrom && mResults[x].GetYear() <= dateTo) 
                {
                    if ((fromCount == 0 && toCount == 0) || 
                        mResults[x].GetRating() >= fromCount && mResults[x].GetRating() <= toCount)
                    {
                        if ((genre+"" == "") || 
                            mResults[x].GetGenres().Contains(genre))
                        {
                            Boolean foundit = false;
                            if(actor4.Text.Length > 0)
                            {
                                for(int y=0; y<mResults[x].GetActors().Count; y++)
                                {
                                    if(mResults[x].GetActorNames()[y].Contains(actor4.Text.ToLower()))
                                    {
                                        foundit = true;
                                    }
                                }
                            }
                            if ((actor4.Visible == false && actor4.Text.Length == 0) || actor4.Text.Length == 0 || foundit)
                            {
                                foundit = false;
                                if(actor3.Text.Length > 0)
                                {
                                    for(int y=0; y<mResults[x].GetActors().Count; y++)
                                    {
                                        if(mResults[x].GetActorNames()[y].Contains(actor3.Text.ToLower()))
                                        {
                                            foundit = true;
                                        }
                                    }
                                }
                                if ((actor3.Visible == false && actor3.Text.Length == 0) || actor3.Text.Length == 0 || foundit)
                                {
                                    foundit = false;
                                    if(actor2.Text.Length > 0)
                                    {
                                        for(int y=0; y<mResults[x].GetActors().Count; y++)
                                        {
                                            if(mResults[x].GetActorNames()[y].Contains(actor2.Text.ToLower()))
                                            {
                                                foundit = true;
                                            }
                                        }
                                    }
                                    if ((actor2.Visible == false && actor2.Text.Length == 0) || actor2.Text.Length == 0 || foundit)
                                    {
                                        foundit = false;
                                        if (actor1.Text.Length > 0)
                                        {
                                            for (int y = 0; y < mResults[x].GetActors().Count; y++)
                                            {
                                                if (mResults[x].GetActorNames()[y].Contains(actor1.Text.ToLower()))
                                                {
                                                    foundit = true;
                                                }
                                            }
                                        }
                                        if (actor1.Text.Length == 0 || foundit)
                                        {
                                            mResultsAdv.Add(mResults[x]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int x = 0; x < actors.Count; x++)
            {
                if (actor4.Text != "" && actors[x].GetName().ToLower().Contains(actor4.Text.ToLower()))
                {
                    aResults.Add(actors[x]);
                }
                else if (actor3.Text != "" && actors[x].GetName().ToLower().Contains(actor3.Text.ToLower()))
                {
                    aResults.Add(actors[x]);
                }
                else if (actor2.Text != "" && actors[x].GetName().ToLower().Contains(actor2.Text.ToLower()))
                {
                    aResults.Add(actors[x]);
                }
                else if (actor1.Text != "" && actors[x].GetName().ToLower().Contains(actor1.Text.ToLower()))
                {
                    aResults.Add(actors[x]);
                }
            }

            if (mResultsAdv.Count > 0)
            {
                searchResultList.Items.Add("Movies:");
                searchResultList.Items.Add(" ");
            }
            searchResultList.Items.AddRange(mResultsAdv.ToArray());
            if (aResults.Count > 0)
            {
                searchResultList.Items.Add(" ");
                searchResultList.Items.Add("Actors:");
                searchResultList.Items.Add(" ");
            }
            searchResultList.Items.AddRange(aResults.ToArray());
        }

        private void loadXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../../../movies.xml");

            XmlNode movieList = xml.DocumentElement.SelectSingleNode("/movielist");

            HashSet<string> genres = new HashSet<string>();

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
            genreSelector.Items.AddRange(genres.ToArray());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchString = searchTextBox.Text;
            searchForString();
        }

        private void fromSlider_Scroll(object sender, EventArgs e)
        {
            if(fromSlider.Value <= toSlider.Value)
            {
                fromDateBox.Text = fromSlider.Value+"";
            }
            else
            {
                fromSlider.Value = toSlider.Value;
            }
        }

        private void toSlider_Scroll(object sender, EventArgs e)
        {
            if (toSlider.Value >= fromSlider.Value)
            {
                toDateBox.Text = toSlider.Value + "";
            }
            else
            {
                toSlider.Value = fromSlider.Value;
            }
        }

        private void searchResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchResultList.SelectedItem.GetType() == movies[0].GetType())
            {
                ItemDetailForm form = new ItemDetailForm((Movie)searchResultList.SelectedItem);
                form.ShowDialog();
            }
            else if (searchResultList.SelectedItem.GetType() == actors[0].GetType())
            {
                ItemDetailForm form = new ItemDetailForm((Actor)searchResultList.SelectedItem);
                form.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
