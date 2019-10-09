using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop.Repository
{
    public class CustomerRepository
    {
        public bool Add(string name, string address, string contact)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"INSERT INTO Customers VALUES('" + name + "','" + address + "', '" + contact + "')";
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
                //MessageBox.Show(exception.Message);
            }

            return isAdded;
        }
        public bool isExists(string name)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Customers WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //CHeck
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return exists;
        }

        public DataTable Display()
        {

            
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();

                //Display
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("Data not found!!!");
                //}
                //Close
                sqlConnection.Close();
                return dataTable;

            

            
        }

        public DataTable Search(string name)
        {
            
           
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT FROM Customers WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Display
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    //showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //   // MessageBox.Show("Data not found!!!");
                //}
                //Close
                sqlConnection.Close();
                return dataTable;




        }

        public bool Update(string name, string address, string contact, int id)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE Customers SET Name = '" + name + "', Address = '" + address + "', Contact='" + contact + "' WHERE Id= " + id + "";
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
                //MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"DELETE FROM Customers WHERE Id='" + id + "'";
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
                   // MessageBox.Show("Data not DEleated!!!");
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return isDeleted;

        }
    }
}
