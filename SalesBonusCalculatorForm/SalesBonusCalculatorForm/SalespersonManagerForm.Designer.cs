namespace SalesBonusCalculatorForm
{
    partial class SalespersonManagerForm
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
            salespersonListBox = new ListBox();
            addButton = new Button();
            actionsGroupBox = new GroupBox();
            closeButton = new Button();
            saveButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            actionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // salespersonListBox
            // 
            salespersonListBox.FormattingEnabled = true;
            salespersonListBox.ItemHeight = 15;
            salespersonListBox.Location = new Point(105, 12);
            salespersonListBox.Name = "salespersonListBox";
            salespersonListBox.Size = new Size(291, 214);
            salespersonListBox.TabIndex = 0;
            salespersonListBox.SelectedIndexChanged += salespersonListBox_SelectedIndexChanged;
            salespersonListBox.DoubleClick += salespersonListBox_DoubleClick;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonFace;
            addButton.Location = new Point(6, 22);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // actionsGroupBox
            // 
            actionsGroupBox.BackColor = SystemColors.ControlLight;
            actionsGroupBox.Controls.Add(closeButton);
            actionsGroupBox.Controls.Add(saveButton);
            actionsGroupBox.Controls.Add(removeButton);
            actionsGroupBox.Controls.Add(editButton);
            actionsGroupBox.Controls.Add(addButton);
            actionsGroupBox.Location = new Point(12, 12);
            actionsGroupBox.Name = "actionsGroupBox";
            actionsGroupBox.Size = new Size(87, 214);
            actionsGroupBox.TabIndex = 2;
            actionsGroupBox.TabStop = false;
            actionsGroupBox.Text = "Actions";
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ButtonFace;
            closeButton.Location = new Point(6, 185);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(6, 109);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = SystemColors.ButtonFace;
            removeButton.Enabled = false;
            removeButton.Location = new Point(6, 80);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.ButtonFace;
            editButton.Enabled = false;
            editButton.Location = new Point(6, 51);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // SalespersonManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 238);
            Controls.Add(actionsGroupBox);
            Controls.Add(salespersonListBox);
            Name = "SalespersonManagerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Sales Reps";
            actionsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox salespersonListBox;
        private Button addButton;
        private GroupBox actionsGroupBox;
        private Button removeButton;
        private Button editButton;
        private Button saveButton;
        private Button closeButton;
    }
}