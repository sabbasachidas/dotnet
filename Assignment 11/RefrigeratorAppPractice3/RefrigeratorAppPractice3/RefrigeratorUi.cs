using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        Refrigeretor aRefrigeretor = new Refrigeretor();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            aRefrigeretor.AddWeight(Convert.ToDouble(maxWeightTakeTextBox.Text));
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            aRefrigeretor.AddItemUnit(Convert.ToDouble(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text));
            if (aRefrigeretor.Validation())
            {
                currentWeightTextBox.Text = aRefrigeretor.CurrentWeight().ToString();
                remainingWeightTextBox.Text = aRefrigeretor.RemainingWeight().ToString();
            }
            else
            {
                MessageBox.Show("Maximum weight limit exceed");
            }
            
        }
    }
}
