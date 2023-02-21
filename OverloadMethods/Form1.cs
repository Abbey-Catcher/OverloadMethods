using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            instructionLabel.Text = "Enter: \n\n1 value for a circle\n2 values for a rectangle";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double num1, num2, answer;

            if (value2Input.Text == "")
            {
                num1 = Convert.ToDouble(value1Input.Text);
                answer = GetArea(num1);
                areaOutput.Text = $"The area of the circle is {answer}";
            }
            else
            {
                num1 = Convert.ToDouble(value1Input.Text);
                num2 = Convert.ToDouble(value2Input.Text);
                answer = GetArea(num1, num2);
                areaOutput.Text = $"The area of the rectangle is {answer}";
            }
        }

        public double GetArea(double radius)
        {
            // double area = 3.14 * radius * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double GetArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
    }
}
