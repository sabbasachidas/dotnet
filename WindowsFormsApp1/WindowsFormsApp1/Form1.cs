using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class personalInfo : Form
    {
        public personalInfo()
        {
            InitializeComponent();
        }

        private void personalInfo_Load(object sender, EventArgs e)
        {

        }

        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string firstName = fNameText.Text;
            

        }

        private void showInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name is " + firstName.Text );
        }
    }
}
