﻿using System;
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
            NumBox.Text = "";
            NameBox.Text = "";
        }
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Num = NumBox.Text;
                String Name = NameBox.Text;
                String Tel = TelBox.Text;
                if (Name == "") throw new Exception();
                newOrder.TelNum = Tel;
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
