using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        SalaryCalculate salaryCalculate = new SalaryCalculate();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(basicAmountTextBox.Text);
            double hohouseRentPercentage = Convert.ToDouble(homeRentTextBox.Text);
            double medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);
            string message = salaryCalculate.Salary(basic, hohouseRentPercentage, medicalAllowancePercentage);
            MessageBox.Show(message);
        }
    }
}
