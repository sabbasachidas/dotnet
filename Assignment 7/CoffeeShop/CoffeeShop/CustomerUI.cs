using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CoffeeShop.Bll;

namespace CoffeeShop
{
    public partial class CustomerUI : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void ItemUI_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if(_customerManager.isExists(nameTextBox.Text))
                {
                MessageBox.Show("Name already exists!!!");
                return;
            }
            if(String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name is required!");
                return;
            }
            bool isAdded = _customerManager.Add(nameTextBox.Text, addressTextBox.Text, contactTextBox.Text);
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }
            showDataGridView.DataSource = _customerManager.Display();
        }
        private void show_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Display();
        }

        private void search_Click(object sender, EventArgs e)
        {
            _customerManager.Search(nameTextBox.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name is required!");
                return;
            }
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address is required!");
                return;
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("COntact is required!");
                return;
            }
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("ID is required!");
                return;
            }
            if (_customerManager.Update(nameTextBox.Text, addressTextBox.Text,contactTextBox.Text,Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated!");
                showDataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
            showDataGridView.DataSource = _customerManager.Display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id can not be empty");
                return;
            }
            if(_customerManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("DEleted!!!");
                showDataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Not DEleted!!!");
            }
        }

        
    }
}
