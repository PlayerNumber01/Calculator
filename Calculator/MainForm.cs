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
    public partial class MainForm : Form
    {
        private readonly Calculator Calculator = new Calculator();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Screen.AppendText("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Screen.AppendText("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Screen.AppendText("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Screen.AppendText("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Screen.AppendText("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Screen.AppendText("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Screen.AppendText("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Screen.AppendText("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Screen.AppendText("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Screen.AppendText("9");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Screen.AppendText("+");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Screen.AppendText("-");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Screen.AppendText("×");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Screen.AppendText("÷");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Screen.AppendText(".");
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text.Substring(1, Screen.Text.Length - 1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void EqualTo_Click(object sender, EventArgs e)
        {
            string result = Calculator.Calculate(Screen.Text);
            Screen.Text = result;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0) return;
            double value = double.Parse(Screen.Text);
            value = Math.Sqrt(value);
            Screen.Text = value.ToString();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0) return;
            double value = double.Parse(Screen.Text);
            value = value * value;
            Screen.Text = value.ToString();
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0) return;
            double value = double.Parse(Screen.Text);
            value = 1.0 / value;
            Screen.Text = value.ToString();
        }

        private void Abs_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0) return;
            double value = double.Parse(Screen.Text);
            value = Math.Abs(value);
            Screen.Text = value.ToString();
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0) return;
            double value = double.Parse(Screen.Text);
            value = -value;
            Screen.Text = value.ToString();
        }
    }
}
