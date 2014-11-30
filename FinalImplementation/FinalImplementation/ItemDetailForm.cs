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
        public ItemDetailForm()
        {
            InitializeComponent();
        }

        public ItemDetailForm(Movie movie)
        {
            InitializeComponent();

            titleLabel.Text = movie.GetTitle() + " (" + movie.GetYear().ToString() + ")";
            this.Text = "Movie Detail Page";
        }

        public ItemDetailForm(Actor actor)
        {
            InitializeComponent();

            titleLabel.Text = actor.GetName();
            this.Text = "Actor Detail Page";
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            ReviewForm form = new ReviewForm();
            form.ShowDialog();
        }
    }
}
