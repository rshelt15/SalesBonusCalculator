using System.Globalization;
using System.Linq.Expressions;

namespace SalesBonusCalculatorForm
{
    // -- TODO -- 
    // save file for settings 
    // add a week range and save sales numbers for that week range
    // csv uploading
    // selecting salesperson filters the listview by that person's sales
    // setting to change minimum sale bonus and label
    // change delete button to delete selected entry instead of last entry
    // help section for how to use the program

    // -- COMPLETED --
    // COMPLETE -- clear all or delete last entry button with are your sure prompt
    // COMPLETE -- tooltips for buttons and numboxes to describe what the button or box is for
    // COMPLETE -- change the way running totals are calculated to be based on ListView instead of manually incrementing based on numboxes
    // COMPLETE -- change minimum sale and BH amount from 0 to "Are you sure?" prompt 
    // COMPLETE -- salesperson name in ListView
    // COMPLETE -- add or remove salespersons and save to file  
    // COMPLETE -- settings menu on MainForm
    // COMPLETE -- add feature to select which salesperson's total to view add running totals based on which salesperson is selected
    // COMPLETE -- csv downloading

    // -- BUGS & ISSUES -- 
    // FIXED -- selecting a salesperson from the view totals box does not update totals.
    // FIXED -- closing prompt for add/edit salesperson opens when saving. Change saveButton to show message saying saved instead of closing

    public partial class MainForm : Form
    {
        // creates a file for storing salespersons
        private readonly string salespersonFilePath = "salespersons.txt";

        private BonusCalculator bonusCalculator = new BonusCalculator(1.75M);

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_Closing;
            this.Shown += (s, e) => salesPersonComboBox.Focus();
            this.MouseDown += MainForm_MouseDown;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // sets the bonus rate label to the default bonus rate
            currentBonusRateLabel.Text = $"Bonus Rate: {bonusCalculator.BonusRate:F2}%";

            // adds columns to ListView
            receiptListView.View = View.Details;
            receiptListView.Columns.Add("Salesperson", 100);
            receiptListView.Columns.Add("Sale Amount", 100);
            receiptListView.Columns.Add("Budget Hours", 100);
            receiptListView.Columns.Add("Bonus Rate (%)", 100);
            receiptListView.Columns.Add("Sales Bonus", 100);
            // sets the size of the columns to match the name of each column
            for (int i = 0; i < receiptListView.Columns.Count; i++)
            {
                receiptListView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // adds tooltips
            toolTip1.SetToolTip(currentJobOkButton, "Add a new job using the entered sale and budget hours.");
            toolTip1.SetToolTip(currentJobDeleteButton, "Remove the most recently added job.");
            toolTip1.SetToolTip(clearButton, "Clear all jobs and reset totals.");
            toolTip1.SetToolTip(currentJobSaleNumBox, "Enter the total dollar amount of the current sale.");
            toolTip1.SetToolTip(currentJobBHNumBox, "Enter the approved budget hours for the current sale.");
            toolTip1.SetToolTip(salesPersonComboBox, "Select a salesperson for the current sale.");
            toolTip1.SetToolTip(settingsToggleButton, "Opens the settings menu");
            toolTip1.SetToolTip(totalsSalespersonComboBox, "Select a salesperson to view individual sales totals");
            toolTip1.SetToolTip(downloadCSVButton, "Save data to a CSV file");

            // loads salespersons from salesperson file
            LoadSalespersonsFromFile();

        }

        /// <summary>
        /// When button is clicked, takes the input values from both NumBoxes
        /// Updates the total values
        /// Calculates sales bonus
        /// Updates the UI to display the totals
        /// Clears the NumBoxValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentJobOkButton_Click(object sender, EventArgs e)
        {
            // Get user inputs
            decimal saleAmount = currentJobSaleNumBox.Value;
            decimal budgetHours = currentJobBHNumBox.Value;

            // Validate 0 inputs with confirmation
            if (saleAmount == 0)
            {
                DialogResult confirmSale = MessageBox.Show(
                    "You entered 0 for the Sale Amount.\nAre you sure you want to continue?",
                    "Confirm Zero Sale Amount",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmSale == DialogResult.No)
                    return;
            }

            if (budgetHours == 0)
            {
                DialogResult confirmBH = MessageBox.Show(
                    "You entered 0 for the Approved Budget Hours.\nAre you sure you want to continue?",
                    "Confirm Zero Budget Hours",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmBH == DialogResult.No)
                    return;
            }

            // Continue if inputs are valid or confirmed
            decimal bonusRate = bonusCalculator.BonusRate;
            decimal bonus = bonusCalculator.CalculateSalesBonus(budgetHours);
            // Adds ListView items
            string salesperson = salesPersonComboBox.SelectedItem?.ToString() ?? "Unknown";
            ListViewItem item = new ListViewItem(salesperson);
            item.SubItems.Add(saleAmount.ToString("C"));
            item.SubItems.Add(budgetHours.ToString());
            item.SubItems.Add(bonusRate.ToString("F2"));
            item.SubItems.Add(bonus.ToString("C"));
            receiptListView.Items.Add(item);
            receiptListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

            // Update totals in UI
            RecalculateAndUpdateTotals();

            // Clear input fields
            currentJobSaleNumBox.Value = 0;
            currentJobBHNumBox.Value = 0;
        }
        /// <summary>
        /// When delete button is clicked, prompts the user to confirm their selection before proceeding to clear the previous job entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentJobDeleteButton_Click(object sender, EventArgs e)
        {
            if (receiptListView.Items.Count == 0)
            {
                MessageBox.Show("There are no jobs to remove.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the most recent job?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ClearLastJob();
            }
        }
        /// <summary>
        /// Clears previous job entry from ListView and removes the values from totals
        /// </summary>
        private void ClearLastJob()
        {
            if (receiptListView.Items.Count == 0)
            {
                MessageBox.Show("There are no jobs to remove.");
                return;
            }

            // Remove the last job entry
            receiptListView.Items.RemoveAt(receiptListView.Items.Count - 1);

            // Recalculate and update all totals and labels
            RecalculateAndUpdateTotals();
        }

        /// <summary>
        /// Calculates the total values for sales, budgeted hours, and bonus from data in the listview
        /// </summary>
        /// <returns></returns>
        private (decimal totalSales, decimal totalBH, decimal totalBonus) RecalculateTotalsFromListViewData() // ChatGPT code
        {
            decimal totalSales = 0;
            decimal totalBH = 0;
            decimal totalBonus = 0;

            foreach (ListViewItem item in receiptListView.Items)
            {
                if (decimal.TryParse(item.SubItems[1].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal sale))
                    totalSales += sale;

                if (decimal.TryParse(item.SubItems[2].Text, out decimal bh))
                    totalBH += bh;

                if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal bonus))
                    totalBonus += bonus;
            }
            return (totalSales, totalBH, totalBonus);
        }

        /// <summary>
        /// Updates running total labels
        /// </summary>
        /// <param name="totalSales"></param>
        /// <param name="totalBH"></param>
        /// <param name="totalBonus"></param>
        private void UpdateRunningTotalLabels(decimal totalSales, decimal totalBH, decimal totalBonus)
        {
            runningTotalSales.Text = totalSales.ToString("C");
            runningTotalBH.Text = totalBH.ToString("F2");
            runningTotalBonus.Text = totalBonus.ToString("C");
        }

        /// <summary>
        /// Recalculates totals and updates labels
        /// </summary>
        private void RecalculateAndUpdateTotals()
        {
            var (sales, bh, bonus) = RecalculateTotalsFromListViewData();
            UpdateRunningTotalLabels(sales, bh, bonus);
        }

        /// <summary>
        /// Clears all job entries and resets totals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e) // ChatGPT code
        {
            DialogResult result = MessageBox.Show(
            "This will clear all job entries and reset all totals.\nAre you sure you want to continue?",
            "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear the ListView
                receiptListView.Items.Clear();

                // Reset tracking
                bonusCalculator.Reset();

                // Reset labels
                runningTotalSales.Text = "$0.00";
                runningTotalBH.Text = "0.00";
                runningTotalBonus.Text = "$0.00";

                // Clear numeric inputs
                currentJobSaleNumBox.Value = 0;
                currentJobBHNumBox.Value = 0;
            }
        }
        /// <summary>
        /// Makes sure sales person combo box is empty when the application starts and loads sales persons from file
        /// </summary>
        private void LoadSalespersonsFromFile()
        {
            salesPersonComboBox.Items.Clear();
            totalsSalespersonComboBox.Items.Clear();
            totalsSalespersonComboBox.Items.Add("All");

            if (File.Exists(salespersonFilePath))
            {
                string[] names = File.ReadAllLines(salespersonFilePath);
                foreach (string name in names)
                {
                    if (!string.IsNullOrWhiteSpace(name))
                        salesPersonComboBox.Items.Add(name.Trim());
                    totalsSalespersonComboBox.Items.Add(name.Trim());
                }
            }
            if (salesPersonComboBox.Items.Count > 0)
                salesPersonComboBox.SelectedIndex = 0;
            if (totalsSalespersonComboBox.Items.Count > 0)
                totalsSalespersonComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Selects all text in numboxes when tabbed into
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, num.Text.Length);
        }
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// changes the calculated totals based on which salesperson is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalsSalespersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = totalsSalespersonComboBox.SelectedItem.ToString();
            if (selected == "All" || selected == null)
            {
                RecalculateAndUpdateTotals();
            }
            else
            {
                var (sales, bh, bonus) = GetTotalsForSalesperson(selected);
                UpdateRunningTotalLabels(sales, bh, bonus);
            }
        }
        private (decimal totalSales, decimal totalBH, decimal totalBonus) GetTotalsForSalesperson(string salesperson) // ChatGPT
        {
            decimal totalSales = 0;
            decimal totalBH = 0;
            decimal totalBonus = 0;

            foreach (ListViewItem item in receiptListView.Items)
            {
                string itemSalesperson = item.SubItems[0].Text;
                if (itemSalesperson == salesperson)
                {
                    if (decimal.TryParse(item.SubItems[1].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal saleAmount))
                        totalSales += saleAmount;
                    if (decimal.TryParse(item.SubItems[2].Text, out decimal bh))
                        totalBH += bh;
                    if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal bonus))
                        totalBonus += bonus;
                }
            }
            return (totalSales, totalBH, totalBonus);
        }

        // -- -- -- -- --
        // TOOLSTRIP MENU
        // -- -- -- -- --
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Reuben Shelton");
        }
        /// <summary>
        /// activates the change bonus rate button when clicked through the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeBonusRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsChangeBonusRateButton_Click(sender, e);
        }
        /// <summary>
        /// activates the manage sales rep button when clicked through the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsManageSalesRepButton_Click(sender, e);
        }

        // -- -- -- -- --
        // SETTINGS MENU
        // -- -- -- -- --
        private void settingsToggleButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = !settingsPanel.Visible;
            if (settingsPanel.Visible)
            {
                settingsToggleButton.BackColor = SystemColors.ButtonShadow;
            }
            else
            {
                settingsToggleButton.BackColor = SystemColors.ButtonFace;
            }
        }

        private void settingsManageSalesRepButton_Click(object sender, EventArgs e)
        {
            using (SalespersonManagerForm form = new SalespersonManagerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSalespersonsFromFile();
                }
            }
        }

        private void settingsChangeBonusRateButton_Click(object sender, EventArgs e)
        {
            using (ChangeBonusRateForm bonusRate = new ChangeBonusRateForm(bonusCalculator.BonusRate))
            {
                if (bonusRate.ShowDialog() == DialogResult.OK)
                {
                    bonusCalculator.UpdateBonusRate(bonusRate.BonusRateSetting);
                    currentBonusRateLabel.Text = $"Bonus Rate: {bonusCalculator.BonusRate:F2}%";
                    MessageBox.Show($"Bonus rate set to: {bonusCalculator.BonusRate:F2}%");
                }
            }
        }
        /// <summary>
        /// closes the settings panel when the user clicks outside of the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e) // ChatGPT code
        {
            // If the settings panel is open and the click is outside the panel and button
            if (settingsPanel.Visible &&
                !settingsPanel.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !settingsToggleButton.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                settingsPanel.Visible = false;
                settingsToggleButton.BackColor = SystemColors.Control;
            }
        }
        /// <summary>
        /// Saves listview data to a CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadCSVButton_Click(object sender, EventArgs e)
        {
            if (receiptListView.Items.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.Title = "Save Sales Data As CSV";
                saveFileDialog.FileName = $"{DateTime.Now:MM_dd_yyyy}_sales_data.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // writes headers
                            string[] headers = receiptListView.Columns
                                .Cast<ColumnHeader>()
                                .Select(col => col.Text)
                                .ToArray();
                            writer.WriteLine(string.Join(",", headers));
                            // writes each row
                            foreach (ListViewItem item in receiptListView.Items)
                            {
                                string[] row = item.SubItems
                                    .Cast<ListViewItem.ListViewSubItem>()
                                    .Select(sub => $"\"{sub.Text}\"")
                                    .ToArray();
                                writer.WriteLine(string.Join(",", row));
                            }
                        }
                        MessageBox.Show("CSV file saved successfully.", "Export Complete");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save file. \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}