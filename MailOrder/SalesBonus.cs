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
            int totalHourWorked = int.Parse(TotalHoursWorkedText.Text);
            double saleBonus = 0.0;
            double totalBonusAmount = 0.0;
            double percentageOfHoursWorked = 0.0;

            if (totalHourWorked >= 0 && totalHourWorked <= 160) {
                percentageOfHoursWorked = totalHourWorked / 160;
                totalBonusAmount = double.Parse(TotalMonthlySalesText.Text) * 0.02;
                saleBonus = totalBonusAmount * percentageOfHoursWorked;
            }
            else {
                MessageBox.Show("Total Hours Worked must be 0-160");
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

        private void EnglishButton_CheckedChanged(object sender, EventArgs e)
        {
            Dictionary<String, String> englishLabel = new Dictionary<String, String>();
            englishLabel.Add("EmployeeIdLabel", "Employee Id");
            englishLabel.Add("EmployeeNameLabel", "Employee Name");
            englishLabel.Add("TotalHoursWorkedLabel", "Total Hours Worked");
            englishLabel.Add("TotalMonthlySalesLabel", "Total Store's Monthly Sale");
            englishLabel.Add("SalesBonusLabel", "Monthly Sales Bonus");
            englishLabel.Add("CalculateButton", "Calculate");
            englishLabel.Add("NextButton", "Next");
            englishLabel.Add("PrintButton", "Print");
            englishLabel.Add("LanguageBox", "Language");
            englishLabel.Add("EnglishButton", "English");
            languageChange(englishLabel);
        }

        private void FrenchButton_CheckedChanged(object sender, EventArgs e)
        {
            Dictionary<String, String> frenchLabel = new Dictionary<String, String>();
            frenchLabel.Add("EmployeeIdLabel", "Id de l’employé");
            frenchLabel.Add("EmployeeNameLabel", "Nom de l’employé");
            frenchLabel.Add("TotalHoursWorkedLabel", "Total d’heures travaillées");
            frenchLabel.Add("TotalMonthlySalesLabel", "Vente mensuelle du total magasin");
            frenchLabel.Add("SalesBonusLabel", "Prime mensuelle à la vente");
            frenchLabel.Add("CalculateButton", "Calculer");
            frenchLabel.Add("NextButton", "Prochaine");
            frenchLabel.Add("PrintButton", "Imprimer");
            frenchLabel.Add("LanguageBox", "Langue");
            frenchLabel.Add("EnglishButton", "Anglais");
            languageChange(frenchLabel);
        }

        private void languageChange(Dictionary<String, String> labelName) {

            foreach (KeyValuePair<string, string> entry in labelName)
            {
                //((Control)entry.Key).Text = entry.Value;
                // do something with entry.Value or entry.Key
            }

        }

    }
}
