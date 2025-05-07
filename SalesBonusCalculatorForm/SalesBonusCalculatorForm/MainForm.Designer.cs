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
            changeBonusRateToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            currentBonusRateLabel = new Label();
            receiptListView = new ListView();
            currentJobDeleteButton = new Button();
            clearButton = new Button();
            toolTip1 = new ToolTip(components);
            salesPersonComboBox = new ComboBox();
            salesPersonLabel = new Label();
            totalsGroupBox = new GroupBox();
            totalsSalespersonComboBox = new ComboBox();
            totalsSalespersonLabel = new Label();
            addSaleGroupBox = new GroupBox();
            settingsToggleButton = new Button();
            settingsPanel = new Panel();
            settingsGroupBox = new GroupBox();
            settingsChangeBonusRateButton = new Button();
            settingsManageSalesRepButton = new Button();
            downloadCSVButton = new Button();
            ((System.ComponentModel.ISupportInitialize)currentJobSaleNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentJobBHNumBox).BeginInit();
            mainMenuStrip.SuspendLayout();
            totalsGroupBox.SuspendLayout();
            addSaleGroupBox.SuspendLayout();
            settingsPanel.SuspendLayout();
            settingsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // currentJobAmountLabel
            // 
            currentJobAmountLabel.AutoSize = true;
            currentJobAmountLabel.Location = new Point(3, 73);
            currentJobAmountLabel.Name = "currentJobAmountLabel";
            currentJobAmountLabel.Size = new Size(123, 25);
            currentJobAmountLabel.TabIndex = 0;
            currentJobAmountLabel.Text = "Sale Amount:";
            // 
            // currentJobBHLabel
            // 
            currentJobBHLabel.AutoSize = true;
            currentJobBHLabel.Location = new Point(3, 118);
            currentJobBHLabel.Name = "currentJobBHLabel";
            currentJobBHLabel.Size = new Size(152, 25);
            currentJobBHLabel.TabIndex = 1;
            currentJobBHLabel.Text = "Budgeted Hours:";
            // 
            // currentJobOkButton
            // 
            currentJobOkButton.BackColor = SystemColors.ButtonFace;
            currentJobOkButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentJobOkButton.Location = new Point(182, 164);
            currentJobOkButton.Name = "currentJobOkButton";
            currentJobOkButton.Size = new Size(163, 41);
            currentJobOkButton.TabIndex = 4;
            currentJobOkButton.Text = "Confirm";
            currentJobOkButton.UseVisualStyleBackColor = false;
            currentJobOkButton.Click += currentJobOkButton_Click;
            // 
            // runningTotalSalesLabel
            // 
            runningTotalSalesLabel.AutoSize = true;
            runningTotalSalesLabel.BackColor = SystemColors.ControlLight;
            runningTotalSalesLabel.Location = new Point(6, 60);
            runningTotalSalesLabel.Name = "runningTotalSalesLabel";
            runningTotalSalesLabel.Size = new Size(46, 20);
            runningTotalSalesLabel.TabIndex = 6;
            runningTotalSalesLabel.Text = "Sales:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(6, 91);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "Budget Hours:";
            // 
            // runningTotalSales
            // 
            runningTotalSales.AutoSize = true;
            runningTotalSales.BackColor = SystemColors.ControlLight;
            runningTotalSales.BorderStyle = BorderStyle.Fixed3D;
            runningTotalSales.Location = new Point(120, 60);
            runningTotalSales.Name = "runningTotalSales";
            runningTotalSales.Size = new Size(46, 22);
            runningTotalSales.TabIndex = 8;
            runningTotalSales.Text = "$0.00";
            // 
            // runningTotalBH
            // 
            runningTotalBH.AutoSize = true;
            runningTotalBH.BackColor = SystemColors.ControlLight;
            runningTotalBH.BorderStyle = BorderStyle.Fixed3D;
            runningTotalBH.Location = new Point(120, 91);
            runningTotalBH.Name = "runningTotalBH";
            runningTotalBH.Size = new Size(38, 22);
            runningTotalBH.TabIndex = 9;
            runningTotalBH.Text = "0.00";
            // 
            // runningTotalBonus
            // 
            runningTotalBonus.AutoSize = true;
            runningTotalBonus.BackColor = SystemColors.ControlLight;
            runningTotalBonus.BorderStyle = BorderStyle.Fixed3D;
            runningTotalBonus.Location = new Point(120, 122);
            runningTotalBonus.Name = "runningTotalBonus";
            runningTotalBonus.Size = new Size(46, 22);
            runningTotalBonus.TabIndex = 10;
            runningTotalBonus.Text = "$0.00";
            // 
            // salesBonusLabel
            // 
            salesBonusLabel.AutoSize = true;
            salesBonusLabel.BackColor = SystemColors.ControlLight;
            salesBonusLabel.Location = new Point(6, 122);
            salesBonusLabel.Name = "salesBonusLabel";
            salesBonusLabel.Size = new Size(52, 20);
            salesBonusLabel.TabIndex = 11;
            salesBonusLabel.Text = "Bonus:";
            // 
            // currentJobSaleNumBox
            // 
            currentJobSaleNumBox.BackColor = SystemColors.Window;
            currentJobSaleNumBox.DecimalPlaces = 2;
            currentJobSaleNumBox.Location = new Point(182, 71);
            currentJobSaleNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            currentJobSaleNumBox.Name = "currentJobSaleNumBox";
            currentJobSaleNumBox.Size = new Size(163, 33);
            currentJobSaleNumBox.TabIndex = 2;
            currentJobSaleNumBox.Enter += numericUpDown_Enter;
            // 
            // currentJobBHNumBox
            // 
            currentJobBHNumBox.Location = new Point(182, 116);
            currentJobBHNumBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            currentJobBHNumBox.Name = "currentJobBHNumBox";
            currentJobBHNumBox.Size = new Size(163, 33);
            currentJobBHNumBox.TabIndex = 3;
            currentJobBHNumBox.Enter += numericUpDown_Enter;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1008, 24);
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
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeBonusRateToolStripMenuItem, salesToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(116, 22);
            toolsToolStripMenuItem.Text = "&Settings";
            // 
            // changeBonusRateToolStripMenuItem
            // 
            changeBonusRateToolStripMenuItem.Name = "changeBonusRateToolStripMenuItem";
            changeBonusRateToolStripMenuItem.Size = new Size(177, 22);
            changeBonusRateToolStripMenuItem.Text = "Change Bonus &Rate";
            changeBonusRateToolStripMenuItem.Click += changeBonusRateToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(177, 22);
            salesToolStripMenuItem.Text = "Edit Sales &People";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
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
            currentBonusRateLabel.BackColor = SystemColors.ControlLight;
            currentBonusRateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            currentBonusRateLabel.Location = new Point(6, 156);
            currentBonusRateLabel.Name = "currentBonusRateLabel";
            currentBonusRateLabel.Size = new Size(86, 19);
            currentBonusRateLabel.TabIndex = 13;
            currentBonusRateLabel.Text = "Bonus Rate: ";
            // 
            // receiptListView
            // 
            receiptListView.BackColor = SystemColors.Info;
            receiptListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptListView.Location = new Point(395, 39);
            receiptListView.Name = "receiptListView";
            receiptListView.Size = new Size(593, 440);
            receiptListView.TabIndex = 15;
            receiptListView.TabStop = false;
            receiptListView.UseCompatibleStateImageBehavior = false;
            // 
            // currentJobDeleteButton
            // 
            currentJobDeleteButton.BackColor = SystemColors.ButtonFace;
            currentJobDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentJobDeleteButton.Location = new Point(395, 485);
            currentJobDeleteButton.Name = "currentJobDeleteButton";
            currentJobDeleteButton.Size = new Size(120, 41);
            currentJobDeleteButton.TabIndex = 7;
            currentJobDeleteButton.Text = "Delete";
            currentJobDeleteButton.UseVisualStyleBackColor = false;
            currentJobDeleteButton.Click += currentJobDeleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ButtonFace;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(521, 485);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(120, 41);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // salesPersonComboBox
            // 
            salesPersonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            salesPersonComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salesPersonComboBox.FormattingEnabled = true;
            salesPersonComboBox.Location = new Point(182, 29);
            salesPersonComboBox.Name = "salesPersonComboBox";
            salesPersonComboBox.Size = new Size(163, 29);
            salesPersonComboBox.TabIndex = 1;
            // 
            // salesPersonLabel
            // 
            salesPersonLabel.AutoSize = true;
            salesPersonLabel.Location = new Point(6, 29);
            salesPersonLabel.Name = "salesPersonLabel";
            salesPersonLabel.Size = new Size(117, 25);
            salesPersonLabel.TabIndex = 19;
            salesPersonLabel.Text = "Salesperson:";
            // 
            // totalsGroupBox
            // 
            totalsGroupBox.BackColor = SystemColors.ControlLight;
            totalsGroupBox.Controls.Add(totalsSalespersonComboBox);
            totalsGroupBox.Controls.Add(totalsSalespersonLabel);
            totalsGroupBox.Controls.Add(salesBonusLabel);
            totalsGroupBox.Controls.Add(currentBonusRateLabel);
            totalsGroupBox.Controls.Add(runningTotalSalesLabel);
            totalsGroupBox.Controls.Add(runningTotalBonus);
            totalsGroupBox.Controls.Add(label1);
            totalsGroupBox.Controls.Add(runningTotalSales);
            totalsGroupBox.Controls.Add(runningTotalBH);
            totalsGroupBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalsGroupBox.Location = new Point(98, 261);
            totalsGroupBox.Name = "totalsGroupBox";
            totalsGroupBox.Size = new Size(274, 192);
            totalsGroupBox.TabIndex = 20;
            totalsGroupBox.TabStop = false;
            totalsGroupBox.Text = "Total";
            // 
            // totalsSalespersonComboBox
            // 
            totalsSalespersonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            totalsSalespersonComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalsSalespersonComboBox.FormattingEnabled = true;
            totalsSalespersonComboBox.Location = new Point(120, 28);
            totalsSalespersonComboBox.Name = "totalsSalespersonComboBox";
            totalsSalespersonComboBox.Size = new Size(139, 25);
            totalsSalespersonComboBox.TabIndex = 6;
            totalsSalespersonComboBox.SelectedIndexChanged += totalsSalespersonComboBox_SelectedIndexChanged;
            // 
            // totalsSalespersonLabel
            // 
            totalsSalespersonLabel.AutoSize = true;
            totalsSalespersonLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            totalsSalespersonLabel.Location = new Point(6, 31);
            totalsSalespersonLabel.Name = "totalsSalespersonLabel";
            totalsSalespersonLabel.Size = new Size(104, 20);
            totalsSalespersonLabel.TabIndex = 15;
            totalsSalespersonLabel.Text = "View totals for:";
            // 
            // addSaleGroupBox
            // 
            addSaleGroupBox.Controls.Add(settingsToggleButton);
            addSaleGroupBox.Controls.Add(salesPersonLabel);
            addSaleGroupBox.Controls.Add(currentJobAmountLabel);
            addSaleGroupBox.Controls.Add(currentJobBHLabel);
            addSaleGroupBox.Controls.Add(salesPersonComboBox);
            addSaleGroupBox.Controls.Add(currentJobOkButton);
            addSaleGroupBox.Controls.Add(currentJobSaleNumBox);
            addSaleGroupBox.Controls.Add(currentJobBHNumBox);
            addSaleGroupBox.Location = new Point(18, 39);
            addSaleGroupBox.Name = "addSaleGroupBox";
            addSaleGroupBox.Size = new Size(371, 216);
            addSaleGroupBox.TabIndex = 21;
            addSaleGroupBox.TabStop = false;
            addSaleGroupBox.Text = "Add Sale";
            // 
            // settingsToggleButton
            // 
            settingsToggleButton.BackColor = SystemColors.ButtonFace;
            settingsToggleButton.FlatAppearance.BorderSize = 0;
            settingsToggleButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsToggleButton.Location = new Point(6, 164);
            settingsToggleButton.Name = "settingsToggleButton";
            settingsToggleButton.Size = new Size(163, 41);
            settingsToggleButton.TabIndex = 23;
            settingsToggleButton.Text = "Settings";
            settingsToggleButton.UseVisualStyleBackColor = false;
            settingsToggleButton.Click += settingsToggleButton_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.BackColor = SystemColors.AppWorkspace;
            settingsPanel.Controls.Add(settingsGroupBox);
            settingsPanel.Location = new Point(21, 27);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(162, 170);
            settingsPanel.TabIndex = 22;
            settingsPanel.Visible = false;
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = SystemColors.ControlLight;
            settingsGroupBox.Controls.Add(settingsChangeBonusRateButton);
            settingsGroupBox.Controls.Add(settingsManageSalesRepButton);
            settingsGroupBox.Location = new Point(12, 9);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(140, 152);
            settingsGroupBox.TabIndex = 0;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // settingsChangeBonusRateButton
            // 
            settingsChangeBonusRateButton.BackColor = SystemColors.ButtonFace;
            settingsChangeBonusRateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsChangeBonusRateButton.Location = new Point(6, 90);
            settingsChangeBonusRateButton.Name = "settingsChangeBonusRateButton";
            settingsChangeBonusRateButton.Size = new Size(128, 52);
            settingsChangeBonusRateButton.TabIndex = 1;
            settingsChangeBonusRateButton.Text = "Change Bonus Rate";
            settingsChangeBonusRateButton.UseVisualStyleBackColor = false;
            settingsChangeBonusRateButton.Click += settingsChangeBonusRateButton_Click;
            // 
            // settingsManageSalesRepButton
            // 
            settingsManageSalesRepButton.BackColor = SystemColors.ButtonFace;
            settingsManageSalesRepButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsManageSalesRepButton.Location = new Point(6, 32);
            settingsManageSalesRepButton.Name = "settingsManageSalesRepButton";
            settingsManageSalesRepButton.Size = new Size(128, 52);
            settingsManageSalesRepButton.TabIndex = 0;
            settingsManageSalesRepButton.Text = "Manage Sales Reps";
            settingsManageSalesRepButton.UseVisualStyleBackColor = false;
            settingsManageSalesRepButton.Click += settingsManageSalesRepButton_Click;
            // 
            // downloadCSVButton
            // 
            downloadCSVButton.BackColor = SystemColors.ButtonFace;
            downloadCSVButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadCSVButton.Location = new Point(868, 485);
            downloadCSVButton.Name = "downloadCSVButton";
            downloadCSVButton.Size = new Size(120, 41);
            downloadCSVButton.TabIndex = 23;
            downloadCSVButton.Text = "Export CSV";
            downloadCSVButton.UseVisualStyleBackColor = false;
            downloadCSVButton.Click += downloadCSVButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 554);
            Controls.Add(downloadCSVButton);
            Controls.Add(settingsPanel);
            Controls.Add(addSaleGroupBox);
            Controls.Add(totalsGroupBox);
            Controls.Add(clearButton);
            Controls.Add(currentJobDeleteButton);
            Controls.Add(receiptListView);
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
            totalsGroupBox.ResumeLayout(false);
            totalsGroupBox.PerformLayout();
            addSaleGroupBox.ResumeLayout(false);
            addSaleGroupBox.PerformLayout();
            settingsPanel.ResumeLayout(false);
            settingsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentJobAmountLabel;
        private Label currentJobBHLabel;
        private Button currentJobOkButton;
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
        private ComboBox salesPersonComboBox;
        private Label salesPersonLabel;
        private ToolStripMenuItem changeBonusRateToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private GroupBox totalsGroupBox;
        private GroupBox addSaleGroupBox;
        private ComboBox totalsSalespersonComboBox;
        private Label totalsSalespersonLabel;
        private Panel settingsPanel;
        private GroupBox settingsGroupBox;
        private Button settingsManageSalesRepButton;
        private Button settingsToggleButton;
        private Button settingsChangeBonusRateButton;
        private Button downloadCSVButton;
    }
}
