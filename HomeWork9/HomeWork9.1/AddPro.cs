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

namespace HomeWork9
{
    public partial class AddPro : Form
    {
        public bool success = false;
        public OrderDetails newOrderDetail = new OrderDetails();
        public void init()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        public AddPro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String ProName = textBox1.Text;
                String ProPrice = textBox2.Text;
                String ProAmount = textBox3.Text;
                if (ProName == "") throw new Exception();
                if (ProPrice == "") throw new Exception();
                if (ProAmount == "") throw new Exception();
                newOrderDetail.TypeOfProduct = ProName;
                newOrderDetail.PriceOfProduct = double.Parse(ProPrice);
                newOrderDetail.AmountOfProduct = int.Parse(ProAmount);
                newOrderDetail.Money = 0;
                success = true;
            }
            catch (Exception eIn)
            {
                OrderInfo.Text = "数据有误";
            }
        }
    }
}
