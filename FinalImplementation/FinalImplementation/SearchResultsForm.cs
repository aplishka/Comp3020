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
    public partial class SearchResultsForm : Form
    {
        public SearchResultsForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(plus1, "Add another actor to search on");
            toolTip1.SetToolTip(plus2, "Add another actor to search on");
            toolTip1.SetToolTip(plus3, "Add another actor to search on");
            toolTip1.SetToolTip(minus2, "Remove this actor from search");
            toolTip1.SetToolTip(minus3, "Remove this actor from search");
            toolTip1.SetToolTip(minus4, "Remove this actor from search");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntryForm form = new DataEntryForm();
            form.ShowDialog();
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
            var plot = plotBox.Text;
            var dateFrom = fromDate.Value;
            var dateTo = toDate.Value;
            string[] actors = new string[4];
            if (actor1.Visible == true && actor1.Text.Length > 0) { actors[0] = actor1.Text; }
            if (actor2.Visible == true && actor2.Text.Length > 0) { actors[1] = actor2.Text; }
            if (actor3.Visible == true && actor3.Text.Length > 0) { actors[2] = actor3.Text; }
            if (actor4.Visible == true && actor4.Text.Length > 0) { actors[3] = actor4.Text; }

            Console.WriteLine(fromCount);
            Console.WriteLine(toCount);
            Console.WriteLine(genre);
            Console.WriteLine(plot);
            Console.WriteLine(dateFrom);
            Console.WriteLine(dateTo);
            Console.WriteLine(actors[0]);
            Console.WriteLine(actors[1]);
            Console.WriteLine(actors[2]);
            Console.WriteLine(actors[3]);
        }
    }
}
