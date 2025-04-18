namespace SalesBonusCalculatorForm
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bonusRateLabel = new Label();
            bonusRateNumBox = new NumericUpDown();
            settingsConfirmButton = new Button();
            settingsCancelButton = new Button();
            label1 = new Label();
            literallyJustAPercentSign = new Label();
            ((System.ComponentModel.ISupportInitialize)bonusRateNumBox).BeginInit();
            SuspendLayout();
            settingsConfirmButton.Click += new EventHandler(settingsConfirmButton_Click);
            settingsCancelButton.Click += new EventHandler(cancelButton_Click);
            // 
            // bonusRateLabel
            // 
            bonusRateLabel.AutoSize = true;
            bonusRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bonusRateLabel.Location = new Point(25, 45);
            bonusRateLabel.Name = "bonusRateLabel";
            bonusRateLabel.Size = new Size(91, 21);
            bonusRateLabel.TabIndex = 0;
            bonusRateLabel.Text = "Bonus Rate:";
            // 
            // bonusRateNumBox
            // 
            bonusRateNumBox.BackColor = SystemColors.Window;
            bonusRateNumBox.DecimalPlaces = 2;
            bonusRateNumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bonusRateNumBox.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            bonusRateNumBox.Location = new Point(122, 43);
            bonusRateNumBox.Name = "bonusRateNumBox";
            bonusRateNumBox.Size = new Size(58, 29);
            bonusRateNumBox.TabIndex = 1;
            // 
            // settingsConfirmButton
            // 
            settingsConfirmButton.Location = new Point(146, 121);
            settingsConfirmButton.Name = "settingsConfirmButton";
            settingsConfirmButton.Size = new Size(104, 43);
            settingsConfirmButton.TabIndex = 3;
            settingsConfirmButton.Text = "Confirm";
            settingsConfirmButton.UseVisualStyleBackColor = true;
            // 
            // settingsCancelButton
            // 
            settingsCancelButton.DialogResult = DialogResult.Cancel;
            settingsCancelButton.Location = new Point(25, 121);
            settingsCancelButton.Name = "settingsCancelButton";
            settingsCancelButton.Size = new Size(104, 43);
            settingsCancelButton.TabIndex = 2;
            settingsCancelButton.Text = "Cancel";
            settingsCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 4;
            label1.Text = "Budget hours x Bonus Rate = Sales Bonus";
            // 
            // literallyJustAPercentSign
            // 
            literallyJustAPercentSign.AutoSize = true;
            literallyJustAPercentSign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            literallyJustAPercentSign.Location = new Point(186, 45);
            literallyJustAPercentSign.Name = "literallyJustAPercentSign";
            literallyJustAPercentSign.Size = new Size(23, 21);
            literallyJustAPercentSign.TabIndex = 5;
            literallyJustAPercentSign.Text = "%";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 185);
            Controls.Add(literallyJustAPercentSign);
            Controls.Add(label1);
            Controls.Add(settingsCancelButton);
            Controls.Add(settingsConfirmButton);
            Controls.Add(bonusRateNumBox);
            Controls.Add(bonusRateLabel);
            Name = "SettingsForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)bonusRateNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bonusRateLabel;
        private NumericUpDown bonusRateNumBox;
        private Button settingsConfirmButton;
        private Button settingsCancelButton;
        private Label label1;
        private Label literallyJustAPercentSign;
    }
}