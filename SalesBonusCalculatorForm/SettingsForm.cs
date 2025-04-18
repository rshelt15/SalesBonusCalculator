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
    public partial class SettingsForm : Form
    {
        public decimal BonusRateSetting { get; private set; }

        public SettingsForm(decimal bonusRate)
        {
            InitializeComponent();

            bonusRateNumBox.DecimalPlaces = 2;
            bonusRateNumBox.Increment = 0.01M;
            bonusRateNumBox.Minimum = 0;
            bonusRateNumBox.Maximum = 100;
            // Clamp value before setting
            var clamped = Math.Min(Math.Max(bonusRate, bonusRateNumBox.Minimum), bonusRateNumBox.Maximum);
            bonusRateNumBox.Value = clamped;
        }

        private void settingsConfirmButton_Click(object sender, EventArgs e)
        {
            BonusRateSetting = bonusRateNumBox.Value;
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
