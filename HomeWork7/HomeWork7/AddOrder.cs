using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork6;

namespace HomeWork7
{
    public partial class AddOrder : Form
    {
        public bool success = false;
        public Order newOrder = new Order();
        public void init()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Num = textBox1.Text;
                String Name = textBox2.Text;
                if (Num == "") throw new Exception();
                if (Name == "") throw new Exception();
                newOrder.OrderNum = Num;
                newOrder.Customer = Name;
                success = true;
            }catch(Exception eIn)
            {
                AddInfo.Text = "数据有误";
            }
        }
    }
}
