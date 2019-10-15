using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        AccountCreation accountCreation = new AccountCreation();
        public void CreateButton_Click(object sender, EventArgs e)
        {
            accountCreation.accountNo = accountNoTextBox.Text;
            accountCreation.customerName = customerNameTextBox.Text;
            
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            accountCreation.Deposit(amount);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            accountCreation.Widthdraw(amount);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string message = accountCreation.GetReport();
            MessageBox.Show(message);
        }
    }
}
