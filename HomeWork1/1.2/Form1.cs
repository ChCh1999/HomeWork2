using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        double[] num;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String Num1 = textBox1.Text;
            double num1 = double.Parse(Num1);
            String Num2 = textBox2.Text;
            double num2 = double.Parse(Num2);
            double Result = num1 * num2;
            result.Text = Num1 + " 和 " + Num2 + "的乘积为  " + Result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
