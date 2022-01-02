using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(184)))));

        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
        }
    }
}
