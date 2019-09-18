using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeShop_day2_
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }
        List<string> names = new List<string> { };
        List<string> contacts = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> orders = new List<string> { };
        List<int> quantities = new List<int> { };
        List<int> amounts = new List<int> { };
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void save_Click(object sender, EventArgs e)
        {
            
            int amount;
            var order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            if(order == "Black - 120")
            {
                amount = 120;
            }
            else if(order == "Cold - 100")
            {
                amount = 100;
            }
            else if(order == "Hot - 90")
            {
                amount = 90;
            }
            else
            {
                amount = 80;
            }
            int netAmount = amount * quantity;

            names.Add(customerNameTextBox.Text);
            contacts.Add(contactTextBox.Text);
            addresses.Add(addressTextBox.Text);
            orders.Add(orderComboBox.Text);
            quantities.Add(Convert.ToInt32(quantityTextBox.Text));
            //amounts.Add = netAmount;
            MessageBox.Show("Information Saved");


            //MessageBox.Show("Information Saved");
            //label6.Text = customerName;
            //label7.Text = Convert.ToString(contactNO) ;
            //label8.Text = address;
            //label9.Text = order;
            //label10.Text = Convert.ToString(quantity);
            //label11.Text = Convert.ToString(amount * quantity);
        }

        private void show_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        private void ShowCustomer()
        {
            
            for (int i = 0; i < names.Count(); i++)
            {
                //message += "Name: " + names[i] + " Age: " + ages[i] + "\n";
                label6.Text +=  names[i] + "   ";
                label7.Text += contacts[i] + "   ";
                label8.Text += addresses[i] + "   ";
                label9.Text += orders[i] + "   ";
                label10.Text += quantities[i];
                //label11.Text += amounts[i];


            }
            

            
        }
    }
}
