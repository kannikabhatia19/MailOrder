/*
 * Application Name : MailOrder
 * 
 * Authour : Kannika Bhatia
 * 
 * Creation Date : 22 January 2017
 * 
 * Description: This is a window application to calculate employee's monthly bonus based on total hours
 * the employee worked out of 160 hours and total store sales in a month
 * 
  */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailOrder
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
        {
            InitializeComponent();
        }

        //This method will calculate the total bonus that the employee makes 
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalHourWorked;
            double.TryParse(TotalHoursWorkedText.Text, out totalHourWorked);
            double saleBonus;
            double totalBonusAmount;
            double percentageOfHoursWorked;
            double totalMonthlySales;
            double.TryParse(TotalMonthlySalesText.Text, out totalMonthlySales);

            if (totalHourWorked < 0 || totalHourWorked > 160) {
                MessageBox.Show("Total Hours Worked must be 0-160");
            }

            if (totalMonthlySales < 0) {
                MessageBox.Show("Total Monthly Sales must be > 0");
            }

            if (totalHourWorked >= 0 && totalHourWorked <= 160) {
                percentageOfHoursWorked = totalHourWorked / 160;
                totalBonusAmount = totalMonthlySales * 0.02;
                saleBonus = totalBonusAmount * percentageOfHoursWorked;
                SalesBonusText.Text = saleBonus.ToString();
            }
            
        }

        //This method will display a message box informing the user that the form is sent to the printer
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form is sent to the printer");
        }

        //This method will remove all text in textbox to prepare for next employee's information
        //to be filled in, except for the store total monthly sales that will be the same for every employee
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameText.Clear();
            EmployeeIdText.Clear();
            TotalHoursWorkedText.Clear();
            SalesBonusText.Clear();
        }
        //This method will change all the labels to English version
        private void EnglishButton_Click(object sender, EventArgs e)
        {
            this.EmployeeIdLabel.Text = Properties.Resources.E_EmployeeId;
            this.EmployeeNameLabel.Text = Properties.Resources.E_EmployeeName;
            this.TotalHoursWorkedLabel.Text = Properties.Resources.E_TotalHoursWorked;
            this.TotalMonthlySalesLabel.Text = Properties.Resources.E_TotalMonthlySales;
            this.SalesBonusLabel.Text = Properties.Resources.E_SalesBonus;
            this.CalculateButton.Text = Properties.Resources.E_Calculate;
            this.NextButton.Text = Properties.Resources.E_Next;
            this.PrintButton.Text = Properties.Resources.E_Print;
            this.EnglishButton.Text = Properties.Resources.E_English;
            this.FrenchButton.Text = Properties.Resources.E_French;
            this.LanguageBox.Text = Properties.Resources.E_Language;
        }

        //This method will change all the labels to French version
        private void FrenchButton_Click(object sender, EventArgs e)
        {
            this.EmployeeIdLabel.Text = Properties.Resources.F_EmployeeId;
            this.EmployeeNameLabel.Text = Properties.Resources.F_EmployeeName;
            this.TotalHoursWorkedLabel.Text = Properties.Resources.F_TotalHoursWorked;
            this.TotalMonthlySalesLabel.Text = Properties.Resources.F_TotalMonthlySales;
            this.SalesBonusLabel.Text = Properties.Resources.F_SalesBonus;
            this.CalculateButton.Text = Properties.Resources.F_Calculate;
            this.NextButton.Text = Properties.Resources.F_Next;
            this.PrintButton.Text = Properties.Resources.F_Print;
            this.EnglishButton.Text = Properties.Resources.F_English;
            this.FrenchButton.Text = Properties.Resources.E_French;
            this.LanguageBox.Text = Properties.Resources.F_Language;
        }
    }
}
