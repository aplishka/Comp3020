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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string[] list = new string[2];
            
            list[0] = "Avatar (2009)";
            list[1] = "The Internship (2013)";
            topMoviesList.Items.AddRange(list);

            list[0] = "Brad Pitt";
            list[1] = "Will Smith";
            topActorsList.Items.AddRange(list);

            list[0] = "Horror";
            list[1] = "Action";
            topGenresList.Items.AddRange(list);
        }

        private void searchData() 
        {
            SearchResultsForm form = new SearchResultsForm();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntryForm form = new DataEntryForm();
            form.ShowDialog();
        }

        private void topMoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> args = new List<string>();
            args.Add(topMoviesList.GetItemText(topMoviesList.SelectedItem));

            ItemDetailForm form = new ItemDetailForm(args);
            form.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void topActorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm();
            form.ShowDialog();
        }

        private void topGenresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] list = new string[2];

            list[0] = "<< Back";
            list[1] = "Some random movie..";

            topGenresList.Items.Clear();
            topGenresList.Items.AddRange(list);
        }
    }
}
