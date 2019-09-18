using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> names = new List<string> { "Nishat" };
        
        private void save_Click(object sender, EventArgs e)
        {
            names.Add(nameTextBox.Text);
            string message = "";
            /* for (int i = 0; i < names.Count(); i++)
            {
                message += "Name : " + names[i] + "\n";
            }*/
            foreach (string name in names)
            {
               message += "Name : " + name + "\n";
            }
            

            MessageBox.Show(message);
        }

        private void ShowCustomer()
        {
            string message = "";
            
            foreach (string name in names)
            {
                message += "Name : " + name + "\n";
            }
            MessageBox.Show(message);
        }

        private void show_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
    }
}
