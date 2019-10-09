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
    public partial class OrderUIcs : Form
    {
        OrderManager _orderManager = new OrderManager();
        public OrderUIcs()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //if (isExists(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name already exists!!!");
            //    return;
            //}
            //if (String.IsNullOrEmpty(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name is required!");
            //    return;
            //}
            bool isAdded = _orderManager.Add(customerNameTextBox.Text, Convert.ToInt32(itemIdTextBox.Text), Convert.ToInt32(QuantityTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }
            _orderManager.Display();
        }

        private void show_Click(object sender, EventArgs e)
        {
            _orderManager.Display();
        }

        private void search_Click(object sender, EventArgs e)
        {
            _orderManager.Search(customerNameTextBox.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name is required!");
            //    return;
            //}
            //if (String.IsNullOrEmpty(addressTextBox.Text))
            //{
            //    MessageBox.Show("Address is required!");
            //    return;
            //}
            //if (String.IsNullOrEmpty(contactTextBox.Text))
            //{
            //    MessageBox.Show("COntact is required!");
            //    return;
            //}
            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID is required!");
            //    return;
            //}
            if (_orderManager.Update(customerNameTextBox.Text, Convert.ToInt32(itemIdTextBox.Text), Convert.ToInt32(QuantityTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated!");
                _orderManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
            _orderManager.Display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("Id can not be empty");
            //    return;
            //}
            if (_orderManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("DEleted!!!");
                _orderManager.Display();
            }
            else
            {
                MessageBox.Show("Not DEleted!!!");
            }
        }

        //private bool isExists(string name)
        //{
        //    bool exists = false;
        //    try
        //    {
        //        //Connection
        //        string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
        //        SqlConnection sqlConnection = new SqlConnection(connectionString);

        //        //Command
        //        string commandStirng = @"SELECT * FROM Orders WHERE Name='" + name + "'";
        //        SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

        //        //Open
        //        sqlConnection.Open();
        //        //CHeck
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);
        //        if (dataTable.Rows.Count > 0)
        //        {
        //            exists = true;
        //        }

        //        //Close
        //        sqlConnection.Close();

        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }

        //    return exists;
        //}
        

    }
}
