using System.Globalization;

namespace SalesBonusCalculatorForm
{
    // -- TODO --
    // add feature to select which salesperson's total to view, including an option for total sales and BH (but not sales bonus)
    // save file for settings
    // csv downloading/uploading
    // csv upload location
    // setting to change minimum sale bonus and label
    // help section for how to use the program
    // add running totals based on which salesperson is selected

    // -- COMPLETED --
    // clear all or delete last entry button with are your sure prompt -- COMPLETE
    // tooltips for buttons and numboxes to describe what the button or box is for -- COMPLETE
    // change the way running totals are calculated to be based on ListView instead of manually incrementing based on numboxes -- COMPLETE
    // change minimum sale and BH amount from 0 to "Are you sure?" prompt -- COMPLETE
    // salesperson name in ListView -- COMPLETE
    // add or remove salespersons and save to file -- COMPLETE

    // BUGS - 

    public partial class MainForm : Form
    {
        // creates a file for storing salespersons
        private readonly string salespersonFilePath = "salespersons.txt";
        // instantiates BonusCalculator class
        private BonusCalculator bonusCalculator = new BonusCalculator(1.75M);

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.Shown += (s, e) => salesPersonComboBox.Focus();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // sets the text of the Job label to the index of the job counter
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
            decimal individualBonus = bonusCalculator.CalculateIndividualSalesBonus(budgetHours);
            // Adds ListView items
            string salesperson = salesPersonComboBox.SelectedItem?.ToString() ?? "Unknown";
            ListViewItem item = new ListViewItem(salesperson);
            item.SubItems.Add(saleAmount.ToString("C"));
            item.SubItems.Add(budgetHours.ToString());
            item.SubItems.Add(bonusRate.ToString("F2"));
            item.SubItems.Add(individualBonus.ToString("C"));
            receiptListView.Items.Add(item);
            receiptListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

            // Update bonus totals
            bonusCalculator.CalculateSalesBonus(budgetHours);

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
        private (decimal totalSales, decimal totalBH, decimal totalBonus) RecalculateTotalsFromListViewData()
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
        private void RecalculateAndUpdateTotals()
        {
            var (sales, bh, bonus) = RecalculateTotalsFromListViewData();
            UpdateRunningTotalLabels(sales, bh, bonus);
        }
        private void UpdateRunningTotalLabels(decimal totalSales, decimal totalBH, decimal totalBonus)
        {
            runningTotalSales.Text = totalSales.ToString("C");
            runningTotalBH.Text = totalBH.ToString();
            runningTotalBonus.Text = totalBonus.ToString("C");
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
                runningTotalBH.Text = "0";
                runningTotalBonus.Text = "$0.00";

                // Clear numeric inputs
                currentJobSaleNumBox.Value = 0;
                currentJobBHNumBox.Value = 0;
            }
        }
        /// <summary>
        /// Ensures sales person combo box is empty when the application starts and loads sales persons from file
        /// </summary>
        private void LoadSalespersonsFromFile()
        {
            salesPersonComboBox.Items.Clear();
            if (File.Exists(salespersonFilePath))
            {
                string[] names = File.ReadAllLines(salespersonFilePath);
                foreach (string name in names)
                {
                    if (!string.IsNullOrWhiteSpace(name))
                        salesPersonComboBox.Items.Add(name.Trim());
                }
            }
            if (salesPersonComboBox.Items.Count > 0)
                salesPersonComboBox.SelectedIndex = 0;
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


        // toolstrip menu methods
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Reuben Shelton");
        }
        /// <summary>
        /// Launches a form to change the bonus rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeBonusRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm(bonusCalculator.BonusRate))
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    bonusCalculator.UpdateBonusRate(settings.BonusRateSetting);
                    currentBonusRateLabel.Text = $"Bonus Rate: {bonusCalculator.BonusRate:F2}%";
                    MessageBox.Show($"Bonus rate set to: {bonusCalculator.BonusRate:F2}%");
                }
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SalespersonManagerForm form = new SalespersonManagerForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadSalespersonsFromFile();
                    }
                }
        }
    }
}