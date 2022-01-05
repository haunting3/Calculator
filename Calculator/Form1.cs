using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Views;
using Calculator.Presenters;

namespace Calculator
{
    public partial class Form1 : Form, ICalculator
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CalculatorPresenter _presenter;

        public string TextNumberOne { get; set; }
        public string TextNumberTwo { get; set; }
        public string TextResult { get; set; }
        public string mathOperator = null;

        private void Teste (string numberTwo)
        {
            _presenter = new CalculatorPresenter(this);
            if (String.Equals(TextResult, numberTwo))
                TextNumberOne = numberTwo;
            else
                TextNumberTwo = numberTwo;

            switch (mathOperator)
            {
                case "+":
                    _presenter.CalcSum();
                    break;
                case "-":
                    _presenter.CalcSubtraction();
                    break;
                case "*":
                    _presenter.CalcMultiplication();
                    break;
                case "/":
                    _presenter.CalcDivison();
                    break;
            }
            textBoxResult.Text = TextResult;
        }
        private void ButtonResult_MouseEnter(object sender, EventArgs e)
        {
            ButtonResult.BackColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(184)))));
        }

        private void ButtonResult_MouseLeave(object sender, EventArgs e)
        {
            ButtonResult.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if(textBoxResult.Text != "0")
                textBoxResult.Text += "0";
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "1";
            else
                textBoxResult.Text = "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "2";
            else
                textBoxResult.Text = "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "3";
            else
                textBoxResult.Text = "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "4";
            else
                textBoxResult.Text = "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "5";
            else
                textBoxResult.Text = "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "6";
            else
                textBoxResult.Text = "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "7";
            else
                textBoxResult.Text = "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "8";
            else
                textBoxResult.Text = "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "0")
                textBoxResult.Text += "9";
            else
                textBoxResult.Text = "9";
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += ".";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length != 0)
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            Teste(textBoxResult.Text);
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            mathOperator = "+";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            mathOperator = "-";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            mathOperator = "*";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }

        private void ButtonDivison_Click(object sender, EventArgs e)
        {
            mathOperator = "/";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            mathOperator = "*";
            TextNumberOne = textBoxResult.Text;
            Teste("-1");
        }
    }
}
