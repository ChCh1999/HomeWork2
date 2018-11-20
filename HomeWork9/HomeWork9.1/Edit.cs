using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork9
{
    public partial class Edit : Form
    {
        public int row ;
        public int column ;
        public String Target;
        public Edit()
        {
            InitializeComponent();
            init("",0,0);
        }
        public void init(String target,int r,int c )
        {
            row = r;
            column = c;
            Info.Text = ":";
            textBox1.Text = "";
            Orgin.Text = target;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String data = textBox1.Text;
            if (data == "")
            {
                Info.Text = "数据错误，请重新输入";
            }
            else
            {
                try
                {
                    Target = data;
                }
                catch (Exception eee)
                {
                    Info.Text = "数据错误，请重新输入";
                }
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
