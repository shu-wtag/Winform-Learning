using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUsingWinform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Num1TextBox.Text = Form1.Text1;
            Num2Textbox.Text = Form1.Text2;
            OperatorTextBox.Text = Form1.Text3;
            ResultTextBox.Text = Form1.Text4;

        }
    }
}
