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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            var customerName = customerNameTextBox.Text;
            int contactNO = Convert.ToInt32(contactTextBox.Text) ;
            var address = addressTextBox.Text;
            var order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int amount;

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

            MessageBox.Show("Information Saved");
            label6.Text = customerName;
            label7.Text = Convert.ToString(contactNO) ;
            label8.Text = address;
            label9.Text = order;
            label10.Text = Convert.ToString(quantity);
            label11.Text = Convert.ToString(amount * quantity);
        }
    }
}
