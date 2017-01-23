namespace MailOrder
{
    partial class SalesBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonus));
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.EmployeeIdText = new System.Windows.Forms.TextBox();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedText = new System.Windows.Forms.TextBox();
            this.TotalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesText = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusText = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.GroupBox();
            this.FrenchButton = new System.Windows.Forms.RadioButton();
            this.EnglishButton = new System.Windows.Forms.RadioButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LanguageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(31, 172);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Location = new System.Drawing.Point(150, 169);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(247, 20);
            this.EmployeeNameText.TabIndex = 1;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Location = new System.Drawing.Point(150, 211);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(176, 20);
            this.EmployeeIdText.TabIndex = 3;
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(31, 214);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(65, 13);
            this.EmployeeIdLabel.TabIndex = 2;
            this.EmployeeIdLabel.Text = "Employee Id";
            // 
            // TotalHoursWorkedText
            // 
            this.TotalHoursWorkedText.AcceptsReturn = true;
            this.TotalHoursWorkedText.Location = new System.Drawing.Point(177, 253);
            this.TotalHoursWorkedText.Name = "TotalHoursWorkedText";
            this.TotalHoursWorkedText.Size = new System.Drawing.Size(149, 20);
            this.TotalHoursWorkedText.TabIndex = 5;
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(28, 256);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(103, 13);
            this.TotalHoursWorkedLabel.TabIndex = 4;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked";
            // 
            // TotalMonthlySalesText
            // 
            this.TotalMonthlySalesText.Location = new System.Drawing.Point(177, 291);
            this.TotalMonthlySalesText.Name = "TotalMonthlySalesText";
            this.TotalMonthlySalesText.Size = new System.Drawing.Size(149, 20);
            this.TotalMonthlySalesText.TabIndex = 7;
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(28, 294);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(130, 13);
            this.TotalMonthlySalesLabel.TabIndex = 6;
            this.TotalMonthlySalesLabel.Text = "Total Store\'s Monthly Sale";
            // 
            // SalesBonusText
            // 
            this.SalesBonusText.Location = new System.Drawing.Point(177, 329);
            this.SalesBonusText.Name = "SalesBonusText";
            this.SalesBonusText.ReadOnly = true;
            this.SalesBonusText.Size = new System.Drawing.Size(149, 20);
            this.SalesBonusText.TabIndex = 9;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(31, 332);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(106, 13);
            this.SalesBonusLabel.TabIndex = 8;
            this.SalesBonusLabel.Text = "Monthly Sales Bonus";
            // 
            // LanguageBox
            // 
            this.LanguageBox.Controls.Add(this.FrenchButton);
            this.LanguageBox.Controls.Add(this.EnglishButton);
            this.LanguageBox.Location = new System.Drawing.Point(276, 22);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(150, 108);
            this.LanguageBox.TabIndex = 10;
            this.LanguageBox.TabStop = false;
            this.LanguageBox.Text = "Languages";
            // 
            // FrenchButton
            // 
            this.FrenchButton.AutoSize = true;
            this.FrenchButton.Location = new System.Drawing.Point(20, 69);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchButton.TabIndex = 1;
            this.FrenchButton.Text = "Français";
            this.FrenchButton.UseVisualStyleBackColor = true;
            this.FrenchButton.CheckedChanged += new System.EventHandler(this.FrenchButton_CheckedChanged);
            // 
            // EnglishButton
            // 
            this.EnglishButton.AutoSize = true;
            this.EnglishButton.Checked = true;
            this.EnglishButton.Location = new System.Drawing.Point(20, 33);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishButton.TabIndex = 0;
            this.EnglishButton.TabStop = true;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.CheckedChanged += new System.EventHandler(this.EnglishButton_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 36);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(258, 84);
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(62, 384);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(167, 384);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(267, 384);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 14;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SalesBonus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(438, 436);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LanguageBox);
            this.Controls.Add(this.SalesBonusText);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesText);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.TotalHoursWorkedText);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.EmployeeIdText);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "SalesBonus";
            this.Text = "Sales Bonus";
            this.LanguageBox.ResumeLayout(false);
            this.LanguageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.TextBox EmployeeIdText;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.TextBox TotalHoursWorkedText;
        private System.Windows.Forms.Label TotalHoursWorkedLabel;
        private System.Windows.Forms.TextBox TotalMonthlySalesText;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.TextBox SalesBonusText;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.RadioButton FrenchButton;
        private System.Windows.Forms.RadioButton EnglishButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrintButton;
    }
}

