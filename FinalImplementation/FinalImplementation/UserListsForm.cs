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
        string MUST_WATCH = "Must-Watch";
        string MUST_BUY = "Must-Buy";

        string mustWatchXmlFile = "../../../../mustWatch.xml";
        string mustBuyXmlFile = "../../../../mustBuy.xml";

        bool mustWatchFlag = false;
        bool mustBuyFlag = false;

        public UserListsForm()
        {
            InitializeComponent();

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
            listBox.Items.Clear();

            XmlDocument xml = new XmlDocument();
            xml.Load(xmlFile);

            XmlNode lists = xml.DocumentElement.SelectSingleNode("/lists");

            foreach (XmlNode list in lists.ChildNodes)
            {
                listBox.Items.Add(list.SelectSingleNode("title").InnerText);
            }
        }

        private void LoadListMoviesFromXml(string listTitle, string xmlFile, ListBox listBox) 
        {
            listBox.Items.Clear();
            listBox.Items.Add("<< Back");

            XDocument doc = XDocument.Load(xmlFile);
            XElement element = doc.Root.Descendants("list").SingleOrDefault(l => (string)l.Element("title") == listTitle);

            if (element != null && element.Descendants("movieTitle").Count() != 0)
            {
                foreach (XElement movie in element.Descendants("movieTitle"))
                {
                    listBox.Items.Add(movie.Element("movieTitle"));
                }
            }            
        }

        private void mustWatchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mustWatchFlag)
            {
                if (this.mustWatchListBox.SelectedItem.ToString() == "<< Back")
                {
                    mustWatchFlag = false;
                    LoadListFromXml(mustWatchXmlFile, this.mustWatchListBox);
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

        private void buyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mustBuyFlag)
            {
                if (this.buyListBox.SelectedItem.ToString() == "<< Back")
                {
                    mustBuyFlag = false;
                    LoadListFromXml(mustBuyXmlFile, this.buyListBox);
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
}
