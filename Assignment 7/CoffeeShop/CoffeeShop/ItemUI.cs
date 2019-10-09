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
    public partial class ItemUI : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUI()
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
            if(_itemManager.isExists(nameTextBox.Text))
                {
                MessageBox.Show("Name already exists!!!");
                return;
            }
            if(String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price is required!");
                return;
            }
            bool isAdded = _itemManager.Add(nameTextBox.Text, Convert.ToInt32(priceTextBox.Text));
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }
            _itemManager.Display();
        }
        private void show_Click(object sender, EventArgs e)
        {
            _itemManager.Display();
        }

        private void search_Click(object sender, EventArgs e)
        {
           _itemManager.Search(nameTextBox.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name is required!");
                return;
            }
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Address is required!");
                return;
            }
            
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("ID is required!");
                return;
            }
            if (_itemManager.Update(nameTextBox.Text, Convert.ToInt32(priceTextBox.Text) , Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated!");
                _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
            _itemManager.Display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id can not be empty");
                return;
            }
            if(_itemManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("DEleted!!!");
                _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not DEleted!!!");
            }
        }

        
        

        
    }
}
