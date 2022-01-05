using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    class CalculatorModel
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }

        public double Sum()
        {
            return NumberOne + NumberTwo;
        }

        public double Subtraction()
        {
            return NumberOne - NumberTwo;
        }

        public double Multiplication()
        {
            return NumberOne * NumberTwo;
        }

        public double Divison()
        {
            return NumberOne / NumberTwo;
        }
    }
}
