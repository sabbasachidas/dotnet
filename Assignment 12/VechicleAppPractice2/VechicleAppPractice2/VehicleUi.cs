using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }
        Vehicle vehicles = new Vehicle();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicles.VehicleCreate(vehicleNameTextBox.Text, regNoTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vehicles.Speed(Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vehicles.MinSpeed().ToString();
            maxSpeedTextBox.Text = vehicles.MaxSpeed().ToString();
            averageSpeedTextBox.Text = vehicles.AvgSpeed().ToString();
        }
    }
}
