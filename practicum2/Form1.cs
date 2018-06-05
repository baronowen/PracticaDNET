using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int r1 = rnd.Next(1, 11);
            int r2 = rnd.Next(1, 11);
            int r3 = rnd.Next(1, 11);

            num1Text.Text = r1.ToString();
            num2Text.Text = r1.ToString();
            num3Text.Text = r1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);
            
            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;

            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;
        }
    }
}
