using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vehicle
    {
        private string vehicleName;
        private string regNo;
        private List<double> speed = new List<double>();
        public string VehicleName { set; get; }
        public string RegNo { set; get; }

        public void VehicleCreate(string vehicleName, string regNo)
        {
            this.vehicleName = vehicleName;
            this.regNo = regNo;
            
        }

        public void Speed(double speed)
        {
            this.speed.Add(speed);
        }

        public double MinSpeed()
        {
            double minSpeed = speed.Min();
            return minSpeed;
        }
        public double MaxSpeed()
        {
            double maxSpeed = speed.Max();
            return maxSpeed;
        }
        public double AvgSpeed()
        {
            double avgSpeed = speed.Average();
            return avgSpeed;
        }

    }
}
