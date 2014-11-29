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

namespace FinalImplementation
{
    public partial class ReviewForm : Form
    {
        StarRatingControl m_starRatingControl = new StarRatingControl();

        public ReviewForm()
        {
            InitializeComponent();

            m_starRatingControl.Top = 45;
            m_starRatingControl.Left = 85;

            Controls.Add(m_starRatingControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
