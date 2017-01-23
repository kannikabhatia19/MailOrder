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
            resources.ApplyResources(this.EmployeeNameLabel, "EmployeeNameLabel");
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            // 
            // EmployeeNameText
            // 
            resources.ApplyResources(this.EmployeeNameText, "EmployeeNameText");
            this.EmployeeNameText.Name = "EmployeeNameText";
            // 
            // EmployeeIdText
            // 
            resources.ApplyResources(this.EmployeeIdText, "EmployeeIdText");
            this.EmployeeIdText.Name = "EmployeeIdText";
            // 
            // EmployeeIdLabel
            // 
            resources.ApplyResources(this.EmployeeIdLabel, "EmployeeIdLabel");
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            // 
            // TotalHoursWorkedText
            // 
            this.TotalHoursWorkedText.AcceptsReturn = true;
            resources.ApplyResources(this.TotalHoursWorkedText, "TotalHoursWorkedText");
            this.TotalHoursWorkedText.Name = "TotalHoursWorkedText";
            // 
            // TotalHoursWorkedLabel
            // 
            resources.ApplyResources(this.TotalHoursWorkedLabel, "TotalHoursWorkedLabel");
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            // 
            // TotalMonthlySalesText
            // 
            resources.ApplyResources(this.TotalMonthlySalesText, "TotalMonthlySalesText");
            this.TotalMonthlySalesText.Name = "TotalMonthlySalesText";
            // 
            // TotalMonthlySalesLabel
            // 
            resources.ApplyResources(this.TotalMonthlySalesLabel, "TotalMonthlySalesLabel");
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            // 
            // SalesBonusText
            // 
            resources.ApplyResources(this.SalesBonusText, "SalesBonusText");
            this.SalesBonusText.Name = "SalesBonusText";
            this.SalesBonusText.ReadOnly = true;
            // 
            // SalesBonusLabel
            // 
            resources.ApplyResources(this.SalesBonusLabel, "SalesBonusLabel");
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            // 
            // LanguageBox
            // 
            resources.ApplyResources(this.LanguageBox, "LanguageBox");
            this.LanguageBox.Controls.Add(this.FrenchButton);
            this.LanguageBox.Controls.Add(this.EnglishButton);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.TabStop = false;
            // 
            // FrenchButton
            // 
            resources.ApplyResources(this.FrenchButton, "FrenchButton");
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.UseVisualStyleBackColor = true;
            this.FrenchButton.CheckedChanged += new System.EventHandler(this.FrenchButton_CheckedChanged);
            // 
            // EnglishButton
            // 
            resources.ApplyResources(this.EnglishButton, "EnglishButton");
            this.EnglishButton.Checked = true;
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.TabStop = true;
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.CheckedChanged += new System.EventHandler(this.EnglishButton_CheckedChanged);
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // CalculateButton
            // 
            resources.ApplyResources(this.CalculateButton, "CalculateButton");
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrintButton
            // 
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SalesBonus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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

