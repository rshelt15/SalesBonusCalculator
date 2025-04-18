using System.Globalization;

namespace SalesBonusCalculatorForm
{
    // TODO - change minimum sale and BH amount from 0 to "Are you sure?" prompt
    // change the way running totals are calculated to be based on ListView instead of manually incrementing based on numboxes -- PRIORITY
    // save file for settings
    // clear all or delete last entry button with are your sure prompt -- COMPLETE
    // tooltips for buttons and numboxes to describe what the button or box is for -- COMPLETE
    // csv downloading/uploading
    // csv upload location
    // salesperson name in ListView
    // add or remove salespersons and save to file
    // setting to change minimum sale bonus
    // help section for how to use the program

    // BUGS - 

    public partial class MainForm : Form
    {
        private JobTracker jobTracker = new JobTracker();
        private BonusCalculator bonusCalculator = new BonusCalculator(1.75M);

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // sets the text of the Job label to the index of the job counter
            currentJobIndexLabel.Text = $"Job {jobTracker.JobIndex}";
            currentBonusRateLabel.Text = $"Bonus Rate: {bonusCalculator.BonusRate:F2}%";

            // adds columns to ListView
            receiptListView.View = View.Details;
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
            bool inputValid = true;
            // Get user inputs
            decimal saleAmount = currentJobSaleNumBox.Value;
            decimal budgetHours = currentJobBHNumBox.Value;

            if (saleAmount <= 0)
            {
                MessageBox.Show($"Invalid input for Sale Amount: ({saleAmount})");
                inputValid = false;
            }
            else if (budgetHours <= 0)
            {
                MessageBox.Show($"Invalid input for Approved BH: ({budgetHours})");
                inputValid = false;
            }
            if (inputValid)
            {
                // Update totals
                jobTracker.UpdateTotalSales(saleAmount);
                jobTracker.UpdateTotalBH(budgetHours);

                //Updates ListView
                decimal bonusRate = bonusCalculator.BonusRate;
                decimal individualBonus = bonusCalculator.CalculateIndividualSalesBonus(budgetHours);
                ListViewItem item = new ListViewItem(saleAmount.ToString("C"));
                item.SubItems.Add(budgetHours.ToString());
                item.SubItems.Add(bonusRate.ToString("F2"));
                item.SubItems.Add(individualBonus.ToString("C"));
                receiptListView.Items.Add(item);

                // Calculates individual sale bonus and updates total
                bonusCalculator.CalculateSalesBonus(budgetHours);

                // Move to next job
                jobTracker.NextJob();

                // Update UI
                currentJobIndexLabel.Text = $"Job {jobTracker.JobIndex}";
                runningTotalSales.Text = jobTracker.TotalSales.ToString("C");
                runningTotalBH.Text = jobTracker.TotalBH.ToString();
                runningTotalBonus.Text = bonusCalculator.TotalSalesBonus.ToString("C");


                // Clear NumBox values
                currentJobSaleNumBox.Value = 0;
                currentJobBHNumBox.Value = 0;
            }
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
                if (decimal.TryParse(item.SubItems[0].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal sale))
                    totalSales += sale;

                if (decimal.TryParse(item.SubItems[1].Text, out decimal bh))
                    totalBH += bh;

                if (decimal.TryParse(item.SubItems[3].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal bonus))
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
                        "Confirm Reset",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Clear the ListView
                        receiptListView.Items.Clear();

                        // Reset all tracking
                        jobTracker.Reset();
                        bonusCalculator.Reset();

                        // Reset labels
                        currentJobIndexLabel.Text = "Job 1";
                        runningTotalSales.Text = "$0.00";
                        runningTotalBH.Text = "0";
                        runningTotalBonus.Text = "$0.00";

                        // Clear numeric inputs
                        currentJobSaleNumBox.Value = 0;
                        currentJobBHNumBox.Value = 0;
                    }
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
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Reuben Shelton");
        }
       
        
    }
}
