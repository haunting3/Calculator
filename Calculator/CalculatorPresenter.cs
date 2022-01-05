using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Views;
using Calculator.Models;

namespace Calculator.Presenters
{
    class CalculatorPresenter
    {
        CalculatorModel calculator = new CalculatorModel();
        
        private ICalculator _calculatorView;

        public CalculatorPresenter(ICalculator view)
        {
            _calculatorView = view;
        }

        public void ConnectBetweenModelAndView()
        {
            calculator.NumberOne = Convert.ToDouble(_calculatorView.TextNumberOne);
            calculator.NumberTwo = Convert.ToDouble(_calculatorView.TextNumberTwo);
        }

        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            _calculatorView.TextResult = calculator.Sum().ToString();
        }

        public void CalcSubtraction()
        {
            ConnectBetweenModelAndView();
            _calculatorView.TextResult = calculator.Subtraction().ToString();
        }

        public void CalcMultiplication()
        {
            ConnectBetweenModelAndView();
            _calculatorView.TextResult = calculator.Multiplication().ToString();
        }

        public void CalcDivison()
        {
            ConnectBetweenModelAndView();
            _calculatorView.TextResult = calculator.Divison().ToString();
        }
    }
}
