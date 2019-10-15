using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculate
    {
        private double firstNumber;
        private double secondNumber;
        public double FirstNumber { set; get; }
        public double SecondNumber { get; set; }

        public void getNumber(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public double Add()
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        public double Subtract()
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        public double Multiply()
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public double Divide()
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
