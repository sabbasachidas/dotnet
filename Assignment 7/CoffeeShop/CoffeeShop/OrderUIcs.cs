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

namespace CoffeeShop
{
    public partial class OrderUIcs : Form
    {
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
            bool isAdded = Add(customerNameTextBox.Text, Convert.ToInt32(itemIdTextBox.Text), Convert.ToInt32(QuantityTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }
           Display();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search(customerNameTextBox.Text);
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
            if (Update(customerNameTextBox.Text, Convert.ToInt32(itemIdTextBox.Text), Convert.ToInt32(QuantityTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated!");
                Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
            Display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("Id can not be empty");
            //    return;
            //}
            if (Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("DEleted!!!");
                Display();
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
        private bool Add(string name, int itemId, int quantity) //, float totalPrice
        {
            bool isAdded = false;
            //float totalValue = 0; 
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"INSERT INTO Orders VALUES('" + name + "'," + itemId + ", "+quantity+")";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isAdded;
        }

        private void Display()
        {

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Orders";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Display
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Data not found!!!");
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void Search(string name)
        {

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Orders WHERE CustomerName='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Display
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Data not found!!!");
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private bool Update(string name, int itemId, int quantity, int id)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE Orders SET CustomerName = '" + name + "', ItemId = '" + itemId + "', Quantity='" + quantity + "' WHERE Id= " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isUpdated = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }

        private bool Delete(int id)
        {
            bool isDeleted = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"DELETE FROM Orders WHERE Id='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();

                //DElete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isDeleted = true;
                }
                else
                {
                    MessageBox.Show("Data not DEleated!!!");
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isDeleted;

        }

    }
}
