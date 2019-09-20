using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_5_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> ids = new List<int> { };
        List<string> names = new List<string> { };
        List<string> mobiles = new List<string> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<int> gpas = new List<int> { };

        public void AddInfo(int id, string name, string mobile, int age, string address, int gpa)
        {
            ids.Add(id);
            names.Add(name);
            mobiles.Add(mobile);
            ages.Add(age);
            addresses.Add(address);
            gpas.Add(gpa);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
         if(String.IsNullOrEmpty(studentIdTextBox.Text) || studentIdTextBox.Text.Length != 4 || ids.Contains(Convert.ToInt32(studentIdTextBox.Text)))
            {
                MessageBox.Show("Enter ID , it must be 4 digit and unique");
                return;
            }
         else if(String.IsNullOrEmpty(nameTextBox.Text) || nameTextBox.Text.Length >= 30)
            {
                MessageBox.Show("Enter name (max 30 character");
                return;
            }
         else if(String.IsNullOrEmpty(mobileTextBox.Text) || mobileTextBox.Text.Length != 11 || mobiles.Contains(mobileTextBox.Text))
            {
                MessageBox.Show("Enter mobile (11 digit and unique)");
                return;
            }
         //else if (gpaTextBox.Text >= 0 && gpaTextBox.Text < 5)
         //   {

         //   }
         else
            {
                AddInfo(Convert.ToInt32(studentIdTextBox.Text), nameTextBox.Text, mobileTextBox.Text, Convert.ToInt32(ageTextBox.Text), addressTextBox.Text, Convert.ToInt32(gpaTextBox.Text));
            }


            //studentIdTextBox.Text = "";
            //nameTextBox.Text = "";
            //mobileTextBox.Text="";
            //ageTextBox.Text = "";
            //addressTextBox.Text = "";
            //gpaTextBox.Text = "";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int i;
            string message = "";
            for (i = 0; i < names.Count; i++) 
            {
                message += "ID: " + ids[i] + "\n" + " Name: " + names[i] + "\n" +" Mobile: " + mobiles[i] + "\n" + " Age: " + ages[i] + "\n" + " Address: " + addresses[i] + "\n"+ " GPA: " + gpas[i] + "\n";


            }
            richTextBox.Text = message;
            maxTextBox.Text = Convert.ToString(gpas.Max());
            minTextBox.Text = Convert.ToString(gpas.Min());
            avgTextBox.Text = Convert.ToString(gpas.Average());
            totalTextBox.Text = Convert.ToString(gpas.Sum());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (radioButtonId.Checked == true)
            {
                if(ids.Contains(Convert.ToInt32(radioInputTextBox.Text)))
                {
                    int index = ids.IndexOf(Convert.ToInt32(radioInputTextBox.Text));
                    MessageBox.Show("ID " + ids[index] + " and name " + names[index] + " is found");

                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else if(radioButtonName.Checked == true)
            {
                if (names.Contains(radioInputTextBox.Text))
                {
                    int index = names.IndexOf(radioInputTextBox.Text);
                    MessageBox.Show(" name " + names[index] + " is found");

                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                if (mobiles.Contains(radioInputTextBox.Text))
                {
                    int index = mobiles.IndexOf(radioInputTextBox.Text);
                    MessageBox.Show("Mobile " + mobiles[index] + " and name " + names[index] + " is found");

                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonId_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
