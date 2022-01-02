using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Views
{
    interface ICalculator
    {
        String TextNumberOne { get; set; }
        String TextNumberTwo { get; set; }
        String TextResult { get; set; }
    }
}
