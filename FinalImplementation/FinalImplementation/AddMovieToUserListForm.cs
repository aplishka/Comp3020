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

namespace FinalImplementation
{
    public partial class AddMovieToUserListForm : Form
    {
        Movie movie;

        string MUST_WATCH = "Must-Watch";
        string MUST_BUY = "Must-Buy";

        string mustWatchXmlFile = "../../../../mustWatch.xml";
        string mustBuyXmlFile = "../../../../mustBuy.xml";

        public AddMovieToUserListForm()
        {
            InitializeComponent();
        }

        public AddMovieToUserListForm(Movie movie)
        {
            InitializeComponent();

            this.movie = movie;
            movieTitleLabel.Text = movie.GetTitle() + " (" + movie.GetYear().ToString() + ")";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.newListTextBox.Enabled = true;
                this.listComboBox.Enabled = false;
            }
            else
            {
                this.newListTextBox.Enabled = false;
                this.listComboBox.Enabled = true;
            }
        }

        private void listTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listTypeComboBox.SelectedText;
            if (selected == MUST_WATCH)
            {
                LoadListComboBox(mustWatchXmlFile);
            } 
            else if (selected == MUST_BUY)
            {
                LoadListComboBox(mustBuyXmlFile);
            }
            else
            {
                this.listComboBox.Items.Clear();
            }
        }

        private void LoadListComboBox(string xmlFile)
        {
            XDocument doc = XDocument.Load(xmlFile);
        }

        private bool ValidateInput()
        {
            bool allFieldsValid = true;

            if (this.listTypeComboBox.SelectedItem == null || (this.listTypeComboBox.SelectedItem.ToString() != MUST_WATCH && this.listTypeComboBox.SelectedItem.ToString() != MUST_BUY))
            {
                errorProvider1.SetError(this.listTypeComboBox, "Must select a valid option");
                allFieldsValid = false;
            }

            if (!this.checkBox1.Checked && !this.listComboBox.Items.Contains(this.listComboBox.Text))
            {
                errorProvider1.SetError(this.listComboBox, "Must select a valid option");
                allFieldsValid = false;
            }

            if (this.checkBox1.Checked && string.IsNullOrWhiteSpace(this.newListTextBox.Text))
            {
                errorProvider1.SetError(this.newListTextBox, "Must enter title for new list");
                allFieldsValid = false;
            }

            return allFieldsValid;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (checkBox1.Checked)
                {

                }
                else
                {

                }
            }
        }
    }
}
