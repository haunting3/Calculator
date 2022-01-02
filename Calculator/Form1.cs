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

        private CalculatorPresenter presenter;

        public string TextNumberOne { get; set; }
        public string TextNumberTwo { get; set; }
        public string TextResult { get; set; }

        public string mathOperator = null;
        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(184)))));
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            TextNumberTwo = textBoxResult.Text;
            presenter = new CalculatorPresenter(this);
            switch (mathOperator)
            {
                case "+":
                    presenter.CalcSum();
                    break;
                case "-":
                    presenter.CalcSubtraction();
                    break;
            }
            textBoxResult.Text = TextResult;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            mathOperator = "+";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            mathOperator = "-";
            TextNumberOne = textBoxResult.Text;
            textBoxResult.Text = "0";
        }
    }
}
