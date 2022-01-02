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
        CalculatorModel _calculator = new CalculatorModel();

        private ICalculator calculatorView;

        public CalculatorPresenter(ICalculator view)
        {
            calculatorView = view;
        }

        public void ConnectBetweenModelAndView()
        {
            _calculator.NumberOne = Convert.ToDouble(calculatorView.TextNumberOne);
            _calculator.NumberTwo = Convert.ToDouble(calculatorView.TextNumberTwo);
        }

        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            calculatorView.TextResult = _calculator.Sum().ToString();
        }

        public void CalcSubtraction()
        {
            ConnectBetweenModelAndView();
            calculatorView.TextResult = _calculator.Subtraction().ToString();
        }
    }
}
