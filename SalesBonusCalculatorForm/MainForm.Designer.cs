namespace SalesBonusCalculatorForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            currentJobAmountLabel = new Label();
            currentJobBHLabel = new Label();
            currentJobOkButton = new Button();
            currentJobIndexLabel = new Label();
            runningTotalSalesLabel = new Label();
            label1 = new Label();
            runningTotalSales = new Label();
            runningTotalBH = new Label();
            runningTotalBonus = new Label();
            salesBonusLabel = new Label();
            currentJobSaleNumBox = new NumericUpDown();
            currentJobBHNumBox = new NumericUpDown();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            currentBonusRateLabel = new Label();
            receiptListView = new ListView();
            currentJobDeleteButton = new Button();
            clearButton = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)currentJobSaleNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentJobBHNumBox).BeginInit();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // currentJobAmountLabel
            // 
            currentJobAmountLabel.AutoSize = true;
            currentJobAmountLabel.Location = new Point(32, 82);
            currentJobAmountLabel.Name = "currentJobAmountLabel";
            currentJobAmountLabel.Size = new Size(123, 25);
            currentJobAmountLabel.TabIndex = 0;
            currentJobAmountLabel.Text = "Sale Amount:";
            // 
            // currentJobBHLabel
            // 
            currentJobBHLabel.AutoSize = true;
            currentJobBHLabel.Location = new Point(32, 133);
            currentJobBHLabel.Name = "currentJobBHLabel";
            currentJobBHLabel.Size = new Size(127, 25);
            currentJobBHLabel.TabIndex = 1;
            currentJobBHLabel.Text = "Approved BH:";
            // 
            // currentJobOkButton
            // 
            currentJobOkButton.BackColor = SystemColors.ButtonFace;
            currentJobOkButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentJobOkButton.Location = new Point(174, 182);
            currentJobOkButton.Name = "currentJobOkButton";
            currentJobOkButton.Size = new Size(120, 32);
            currentJobOkButton.TabIndex = 4;
            currentJobOkButton.Text = "Confirm";
            currentJobOkButton.UseVisualStyleBackColor = false;
            currentJobOkButton.Click += currentJobOkButton_Click;
            // 
            // currentJobIndexLabel
            // 
            currentJobIndexLabel.AutoSize = true;
            currentJobIndexLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentJobIndexLabel.Location = new Point(132, 34);
            currentJobIndexLabel.Name = "currentJobIndexLabel";
            currentJobIndexLabel.Size = new Size(55, 25);
            currentJobIndexLabel.TabIndex = 5;
            currentJobIndexLabel.Text = "Job 1";
            // 
            // runningTotalSalesLabel
            // 
            runningTotalSalesLabel.AutoSize = true;
            runningTotalSalesLabel.BorderStyle = BorderStyle.Fixed3D;
            runningTotalSalesLabel.Location = new Point(32, 303);
            runningTotalSalesLabel.Name = "runningTotalSalesLabel";
            runningTotalSalesLabel.Size = new Size(106, 27);
            runningTotalSalesLabel.TabIndex = 6;
            runningTotalSalesLabel.Text = "Total Sales:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(32, 347);
            label1.Name = "label1";
            label1.Size = new Size(87, 27);
            label1.TabIndex = 7;
            label1.Text = "Total BH:";
            // 
            // runningTotalSales
            // 
            runningTotalSales.AutoSize = true;
            runningTotalSales.BackColor = SystemColors.GradientInactiveCaption;
            runningTotalSales.BorderStyle = BorderStyle.Fixed3D;
            runningTotalSales.Location = new Point(174, 303);
            runningTotalSales.Name = "runningTotalSales";
            runningTotalSales.Size = new Size(58, 27);
            runningTotalSales.TabIndex = 8;
            runningTotalSales.Text = "$0.00";
            // 
            // runningTotalBH
            // 
            runningTotalBH.AutoSize = true;
            runningTotalBH.BackColor = SystemColors.GradientInactiveCaption;
            runningTotalBH.BorderStyle = BorderStyle.Fixed3D;
            runningTotalBH.Location = new Point(208, 347);
            runningTotalBH.Name = "runningTotalBH";
            runningTotalBH.Size = new Size(24, 27);
            runningTotalBH.TabIndex = 9;
            runningTotalBH.Text = "0";
            // 
            // runningTotalBonus
            // 
            runningTotalBonus.AutoSize = true;
            runningTotalBonus.BackColor = SystemColors.GradientInactiveCaption;
            runningTotalBonus.BorderStyle = BorderStyle.Fixed3D;
            runningTotalBonus.Location = new Point(174, 394);
            runningTotalBonus.Name = "runningTotalBonus";
            runningTotalBonus.Size = new Size(58, 27);
            runningTotalBonus.TabIndex = 10;
            runningTotalBonus.Text = "$0.00";
            // 
            // salesBonusLabel
            // 
            salesBonusLabel.AutoSize = true;
            salesBonusLabel.BorderStyle = BorderStyle.Fixed3D;
            salesBonusLabel.Location = new Point(32, 394);
            salesBonusLabel.Name = "salesBonusLabel";
            salesBonusLabel.Size = new Size(118, 27);
            salesBonusLabel.TabIndex = 11;
            salesBonusLabel.Text = "Sales Bonus:";
            // 
            // currentJobSaleNumBox
            // 
            currentJobSaleNumBox.BackColor = SystemColors.Window;
            currentJobSaleNumBox.DecimalPlaces = 2;
            currentJobSaleNumBox.Location = new Point(174, 80);
            currentJobSaleNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            currentJobSaleNumBox.Name = "currentJobSaleNumBox";
            currentJobSaleNumBox.Size = new Size(120, 33);
            currentJobSaleNumBox.TabIndex = 1;
            currentJobSaleNumBox.Enter += numericUpDown_Enter;
            // 
            // currentJobBHNumBox
            // 
            currentJobBHNumBox.Location = new Point(174, 131);
            currentJobBHNumBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            currentJobBHNumBox.Name = "currentJobBHNumBox";
            currentJobBHNumBox.Size = new Size(120, 33);
            currentJobBHNumBox.TabIndex = 2;
            currentJobBHNumBox.Enter += numericUpDown_Enter;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(940, 24);
            mainMenuStrip.TabIndex = 12;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(116, 22);
            toolsToolStripMenuItem.Text = "&Settings";
            toolsToolStripMenuItem.Click += toolsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // currentBonusRateLabel
            // 
            currentBonusRateLabel.AutoSize = true;
            currentBonusRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            currentBonusRateLabel.Location = new Point(32, 437);
            currentBonusRateLabel.Name = "currentBonusRateLabel";
            currentBonusRateLabel.Size = new Size(94, 21);
            currentBonusRateLabel.TabIndex = 13;
            currentBonusRateLabel.Text = "Bonus Rate: ";
            // 
            // receiptListView
            // 
            receiptListView.BackColor = SystemColors.Info;
            receiptListView.Location = new Point(314, 80);
            receiptListView.Name = "receiptListView";
            receiptListView.Size = new Size(596, 412);
            receiptListView.TabIndex = 15;
            receiptListView.TabStop = false;
            receiptListView.UseCompatibleStateImageBehavior = false;
            // 
            // currentJobDeleteButton
            // 
            currentJobDeleteButton.BackColor = SystemColors.ButtonFace;
            currentJobDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentJobDeleteButton.Location = new Point(174, 220);
            currentJobDeleteButton.Name = "currentJobDeleteButton";
            currentJobDeleteButton.Size = new Size(120, 32);
            currentJobDeleteButton.TabIndex = 16;
            currentJobDeleteButton.Text = "Delete";
            currentJobDeleteButton.UseVisualStyleBackColor = false;
            currentJobDeleteButton.Click += currentJobDeleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ButtonFace;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(30, 474);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(120, 32);
            clearButton.TabIndex = 17;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 536);
            Controls.Add(clearButton);
            Controls.Add(currentJobDeleteButton);
            Controls.Add(receiptListView);
            Controls.Add(currentBonusRateLabel);
            Controls.Add(currentJobBHNumBox);
            Controls.Add(currentJobSaleNumBox);
            Controls.Add(salesBonusLabel);
            Controls.Add(runningTotalBonus);
            Controls.Add(runningTotalBH);
            Controls.Add(runningTotalSales);
            Controls.Add(label1);
            Controls.Add(runningTotalSalesLabel);
            Controls.Add(currentJobIndexLabel);
            Controls.Add(currentJobOkButton);
            Controls.Add(currentJobBHLabel);
            Controls.Add(currentJobAmountLabel);
            Controls.Add(mainMenuStrip);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Sales Bonus Calculator";
            ((System.ComponentModel.ISupportInitialize)currentJobSaleNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentJobBHNumBox).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentJobAmountLabel;
        private Label currentJobBHLabel;
        private Button currentJobOkButton;
        private Label currentJobIndexLabel;
        private Label runningTotalSalesLabel;
        private Label label1;
        private Label runningTotalSales;
        private Label runningTotalBH;
        private Label runningTotalBonus;
        private Label salesBonusLabel;
        private NumericUpDown currentJobSaleNumBox;
        private NumericUpDown currentJobBHNumBox;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label currentBonusRateLabel;
        private ListView receiptListView;
        private Button currentJobDeleteButton;
        private Button clearButton;
        private ToolTip toolTip1;
    }
}
