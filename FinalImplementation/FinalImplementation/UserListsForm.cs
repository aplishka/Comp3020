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
using System.Xml.Linq;

namespace FinalImplementation
{
    public partial class UserListsForm : Form
    {
        private List<Actor> actors;

        string MUST_WATCH = "Must-Watch";
        string MUST_BUY = "Must-Buy";

        string mustWatchXmlFile = "../../../../mustWatch.xml";
        string mustBuyXmlFile = "../../../../mustBuy.xml";

        bool mustWatchFlag = false;
        bool mustBuyFlag = false;

        public UserListsForm(List<Actor> actors)
        {
            InitializeComponent();

            this.actors = actors;

            this.listTypeComboBox.Items.Add(MUST_WATCH);
            this.listTypeComboBox.Items.Add(MUST_BUY);

            LoadLists();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string xmlFile = this.listTypeComboBox.SelectedItem.ToString() == MUST_WATCH ? mustWatchXmlFile : mustBuyXmlFile;
                XDocument doc = XDocument.Load(xmlFile);
                XElement element = new XElement("list",
                    new XElement("title", this.newListTextBox.Text)
                    );
                doc.Root.Add(element);
                doc.Save(xmlFile);

                ListBox listBox = this.listTypeComboBox.SelectedItem.ToString() == MUST_WATCH ? this.mustWatchListBox : this.buyListBox;
                LoadListFromXml(xmlFile, listBox);
            }
        }

        private bool ValidateInput()
        {
            bool allFieldsValid = true;

            if (this.listTypeComboBox.SelectedItem == null || (this.listTypeComboBox.SelectedItem.ToString() != MUST_WATCH && this.listTypeComboBox.SelectedItem.ToString() != MUST_BUY))
            {
                errorProvider1.SetError(this.listTypeComboBox, "Must select a valid option");
                allFieldsValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.newListTextBox.Text))
            {
                errorProvider1.SetError(this.newListTextBox, "Must enter title for new list");
                allFieldsValid = false;
            }

            return allFieldsValid;
        }

        private void LoadLists()
        {
            LoadListFromXml(mustWatchXmlFile, this.mustWatchListBox);
            LoadListFromXml(mustBuyXmlFile, this.buyListBox);
        }

        private void LoadListFromXml(string xmlFile, ListBox listBox)
        {
            List<string> list_list = new List<string>();
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlFile);

            XmlNode lists = xml.DocumentElement.SelectSingleNode("/lists");

            foreach (XmlNode list in lists.ChildNodes)
            {
                list_list.Add(list.SelectSingleNode("title").InnerText);
            }

            listBox.Items.Clear();
            string[] lists_to_add = list_list.ToArray();
            Array.Sort(lists_to_add);
            listBox.Items.AddRange(lists_to_add);
        }

        private void LoadListMoviesFromXml(string listTitle, string xmlFile, ListBox listBox) 
        {
            List<string> list_list = new List<string>();
            XDocument doc = XDocument.Load(xmlFile);
            XElement element = doc.Root.Descendants("list").SingleOrDefault(l => (string)l.Element("title") == listTitle);

            if (element != null && element.Descendants("movieTitle").Count() != 0)
            {
                foreach (XElement movie in element.Descendants("movieTitle"))
                {
                    list_list.Add(movie.Value);
                }
            }

            listBox.Items.Clear();
            listBox.Items.Add("<< Back");
            string[] lists_to_add = list_list.ToArray();
            Array.Sort(lists_to_add);
            listBox.Items.AddRange(lists_to_add);
        }

        private void mustWatchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.mustWatchListBox.SelectedItem != null)
            {
                if (mustWatchFlag)
                {
                    if (this.mustWatchListBox.SelectedItem.ToString() == "<< Back")
                    {
                        mustWatchFlag = false;
                        LoadListFromXml(mustWatchXmlFile, this.mustWatchListBox);
                    }
                    else
                    {
                        OpenMovieDetailForm(this.mustWatchListBox.SelectedItem.ToString());
                    }
                }
                else
                {
                    mustWatchFlag = true;

                    LoadListMoviesFromXml(this.mustWatchListBox.SelectedItem.ToString(),
                        mustWatchXmlFile,
                        this.mustWatchListBox
                        );
                }
            }
        }

        private void buyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.buyListBox.SelectedItem != null)
            {
                if (mustBuyFlag)
                {
                    if (this.buyListBox.SelectedItem.ToString() == "<< Back")
                    {
                        mustBuyFlag = false;
                        LoadListFromXml(mustBuyXmlFile, this.buyListBox);
                    }
                    else
                    {
                        OpenMovieDetailForm(this.buyListBox.SelectedItem.ToString());
                    }
                }
                else
                {
                    mustBuyFlag = true;

                    LoadListMoviesFromXml(this.buyListBox.SelectedItem.ToString(),
                        mustBuyXmlFile,
                        this.buyListBox
                        );
                }
            }
        }

        private Movie LoadMovieFromXml(string movietitle)
        {
            XDocument doc = XDocument.Load("../../../../movies.xml");
            XElement movieElement = doc.Root.Descendants("movie").SingleOrDefault(m => (string)m.Element("title") == movietitle);
            
            List<Actor> currActors = new List<Actor>();
            List<string> currGenres = new List<string>();
            List<Review> currReviews = new List<Review>();

            foreach (XElement actor in movieElement.Elements("actor"))
            {
                currActors.Add(actors.Find(a => a.GetName() == actor.Value));
            }

            foreach (XElement genre in movieElement.Elements("genre"))
            {
                currGenres.Add(genre.Value);
            }

            foreach (XElement review in movieElement.Elements("review"))
            {                
                string[] splitOn = {"|break|"};
                string[] arr = review.Value.Split(splitOn,System.StringSplitOptions.None);
                currReviews.Add(new Review(Convert.ToInt32(arr[0]),arr[1],arr[2]));
            }

            Movie newMovie = new Movie(movieElement.Element("title").Value,
                Int32.Parse(movieElement.Element("year").Value),
                currActors,
                currGenres,
                movieElement.Element("certification") == null ? "" : movieElement.Element("certification").Value,
                Int32.Parse(movieElement.Element("rating").Value),
                Int32.Parse((movieElement.Element("length").Value.Split(' '))[0]),
                movieElement.Element("director").Value,
                currReviews
                );

            return newMovie;
        }

        private void OpenMovieDetailForm(string movieTitle)
        {
            ItemDetailForm form = new ItemDetailForm(LoadMovieFromXml(movieTitle));
            form.ShowDialog();
        }
    }
}
