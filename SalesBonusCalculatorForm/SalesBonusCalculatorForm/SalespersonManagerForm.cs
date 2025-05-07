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
    public partial class SalespersonManagerForm : Form
    {
        private bool hasChangesMade = false;
        public SalespersonManagerForm()
        {
            InitializeComponent();
            this.Load += SalespersonManagerForm_Load;
            this.FormClosing += SalespersonManagerForm_Closing;
        }
        private void SalespersonManagerForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("salespersons.txt"))
            {
                string[] names = File.ReadAllLines("salespersons.txt");
                salespersonListBox.Items.Clear();
                foreach (string name in names)
                {
                    if (!string.IsNullOrWhiteSpace(name))
                        salespersonListBox.Items.Add(name.Trim());
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            using (EditSalespersonForm form = new EditSalespersonForm(isEditMode: false))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    string fullName = $"{form.FirstName} {form.LastName}";
                    if (!salespersonListBox.Items.Contains(fullName))
                    {
                        salespersonListBox.Items.Add(fullName);
                        salespersonListBox.SelectedItem = fullName;
                        hasChangesMade = true;
                    }
                    else
                    {
                        MessageBox.Show($"{fullName} already exists.");
                    }

                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string[] parts = salespersonListBox.SelectedItem.ToString().Split(' ');
            string currentFirst = parts.Length > 0 ? parts[0] : "";
            string currentLast = parts.Length > 1 ? string.Join(" ", parts.Skip(1)) : "";

            using (EditSalespersonForm form = new EditSalespersonForm(currentFirst, currentLast, isEditMode: true))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string fullName = $"{form.FirstName} {form.LastName}";

                    if (!salespersonListBox.Items.Contains(fullName))
                    {
                        salespersonListBox.Items[salespersonListBox.SelectedIndex] = fullName;
                        hasChangesMade = true;
                    }
                    else
                    {
                        MessageBox.Show($"{fullName} already exists.");
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (salespersonListBox.SelectedItem == null)
                return;

            string name = salespersonListBox.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove {name}?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                salespersonListBox.Items.Remove(salespersonListBox.SelectedItem);
                hasChangesMade = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();

            foreach (var item in salespersonListBox.Items)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                    names.Add(item.ToString().Trim());
            }

            File.WriteAllLines("salespersons.txt", names);
            MessageBox.Show("Changes saved successfully.");
            hasChangesMade = false;
        }

        /// <summary>
        /// Disables edit and remove when nothing is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salespersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasSelection = salespersonListBox.SelectedIndex != -1;
            editButton.Enabled = hasSelection;
            removeButton.Enabled = hasSelection;
        }

        private void salespersonListBox_DoubleClick(object sender, EventArgs e)
        {
            if (salespersonListBox != null)
            {
                editButton.PerformClick();
            }
        }
        private void SalespersonManagerForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (hasChangesMade == true)
            {
                var result = MessageBox.Show("You have unsaved changes that will be lost, are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
