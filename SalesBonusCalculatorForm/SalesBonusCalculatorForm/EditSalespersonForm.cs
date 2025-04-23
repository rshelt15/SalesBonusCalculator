using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesBonusCalculatorForm
{
    public partial class EditSalespersonForm : Form
    {
        public string FirstName => firstNameTextBox.Text.Trim();
        public string LastName => lastNameTextBox.Text.Trim();

        public EditSalespersonForm(string firstname = "", string lastname = "", bool isEditMode = false)
        {
            InitializeComponent();

            this.Shown += (s, e) => firstNameTextBox.Focus();
            firstNameTextBox.Text = firstname;
            lastNameTextBox.Text = lastname;
            groupBox1.Text = isEditMode ? "Edit Salesperson" : "Add Salesperson";
            this.AcceptButton = acceptButton;
            this.CancelButton = cancelButton;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Please enter both first and last names.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
