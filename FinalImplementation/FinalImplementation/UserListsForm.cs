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
    public partial class UserListsForm : Form
    {
        string MUST_WATCH = "Must-Watch";
        string MUST_BUY = "Must-Buy";

        public UserListsForm()
        {
            InitializeComponent();

            this.listTypeComboBox.Items.Add(MUST_WATCH);
            this.listTypeComboBox.Items.Add(MUST_BUY);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

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
    }
}
