using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class SalaryCalculate
    {
        public string employeeName;
        public double totalSalary;
        public double houseRent;
        public double medicalAllowance;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public string Salary(double basic, double houseRentPercentage, double medicalAllowancePercentage)
        {
            houseRent = (basic / 100) * houseRentPercentage;
            medicalAllowance = (basic / 100) * medicalAllowancePercentage;
            
            totalSalary = (basic + houseRent + medicalAllowance);
            var message = "Name: " + employeeName + " Salary: " + totalSalary;
            return message;
        }
        
    }
    }
    

